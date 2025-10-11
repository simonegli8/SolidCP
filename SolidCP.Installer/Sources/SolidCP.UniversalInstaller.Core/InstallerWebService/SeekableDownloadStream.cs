using Nito.AsyncEx;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SolidCP.UniversalInstaller;

public class SeekableDownloadStream : System.IO.Stream
{
	public const int MB = 1024 * 1024;
	public const int ChunkSize = 4 * MB;

	public Releases Releases;

	(long Position, int Size, Task<Task> Data)[] Chunks;
	FileStream Buffer;
	int min = 0, current = 0;
	Task<long> Size = null;
	string TmpFile;
	AsyncLock ChunkLock = new AsyncLock();
	AsyncLock IOLock = new AsyncLock();
	DateTime Start;
	TimeSpan DownloadTime = new TimeSpan(0);
	long Bufposition = 0;
	public Task DownloadComplete;
	public bool IsTemp;
	public Action<long, long> Progress;
	public string Url;
	public SeekableDownloadStream(Releases releases, string url, string tmpFile, bool isTemp = true,
		Action<long, long> progress = null)
	{
		Start = DateTime.Now;
		Releases = releases;
		TmpFile = tmpFile;
		Url = url;
		IsTemp = isTemp;
		Progress = progress;
		Buffer = new FileStream(TmpFile, FileMode.Create, FileAccess.ReadWrite);
		DownloadComplete = DownloadSequential();
	}

	async Task GetSize()
	{
		using (var alock = await ChunkLock.LockAsync())
		{
			if (Size == null) Size = Releases.GetFileSizeAsync(Url);
		}
	}
	async Task<long> DownloadChunkAsync(int position, int count, byte[] buffer)
	{
		var start = DateTime.Now;
		var size = await Releases.DownloadFileChunkAsync(Url, position, count, buffer);
		DownloadTime += DateTime.Now - start;
		return size;
	}
	void GetChunk(long size, int i)
	{
		using (var alock = ChunkLock.Lock())
		{
			var chunk = Chunks[i];
			if (Buffer != null && chunk.Data == null)
			{
				if (Buffer == null)
				{
					chunk.Position = 0;
					chunk.Size = 0;
					chunk.Data = Task.FromResult(Task.CompletedTask);
					return;
				}
				chunk.Position = Buffer.Length;
				var bufpos = ((long)i) * ChunkSize;
				chunk.Size = Math.Min(ChunkSize, (int)(size - bufpos));
				Buffer.SetLength(chunk.Position + chunk.Size);
				var buffer = ArrayPool<byte>.Shared.Rent(ChunkSize);
				chunk.Data = DownloadChunkAsync(i * ChunkSize, chunk.Size, buffer)
					.ContinueWith(async task =>
					{
						var rented = buffer;
						try
						{
							using (var îolock = await IOLock.LockAsync())
							{
								if (Buffer != null)
								{
									if (Buffer.Position != chunk.Position) Buffer.Seek(chunk.Position, SeekOrigin.Begin);
									long length = task.Result;
									await Buffer.WriteAsync(rented, 0, (int)length);
									await Buffer.FlushAsync();
								}
							}
						}
						finally
						{
							if (rented != null) ArrayPool<byte>.Shared.Return(rented);
						}
					});
				Chunks[i] = chunk;
			}
		}
	}

	public async Task DownloadSequential()
	{
		await GetSize();
		var size = await Size;
		Chunks = new (long Position, int Size, Task<Task> Data)[(int)(size / ChunkSize) + (size % ChunkSize == 0 ? 0 : 1)];
		long downloaded = 0;
		for (int i = 0; i < Chunks.Length; i++)
		{
			if (Releases.Cancel.IsCancellationRequested) break;

			GetChunk(size, i);
			if (Chunks[i].Data != null) await Chunks[i].Data;

			downloaded += Chunks[i].Size;
			Progress?.Invoke(Math.Min(downloaded, size), size);
		}
	}

	public override long Length
	{
		get
		{
			while (Size == null)
			{
				Thread.Sleep(0);
			}
			return Size.Result;
		}
	}

	public override long Position
	{
		get;
		set;
	}
	public override int Read(byte[] buffer, int offset, int count)
	{
		var size = Length;
		// return 0 for EOF (important to avoid indexing past Chunks)
		if (Position >= size) return 0;

		int nread = 0, nreadchunk;
		while (count > 0 && offset < buffer.Length && Position < size)
		{
			var i = (int)(Position / ChunkSize);
			// safety: ensure i is in bounds
			if (i < 0 || i >= Chunks.Length) return nread;

			GetChunk(size, i);
			var chunk = Chunks[i];
			var posoffset = (int)(Position % ChunkSize);
			var bufpos = chunk.Position + posoffset;
			var chunkcount = Math.Min(count, ChunkSize - posoffset);
			if (Position + chunkcount > Length) chunkcount = (int)(Length - Position);
			if (chunkcount <= 0) break;
			chunk.Data.Unwrap().Wait();
			using (var iolock = IOLock.Lock())
			{
				if (Buffer == null) return nread;
				if (Buffer.Position != bufpos) Buffer.Seek(bufpos, SeekOrigin.Begin);
				nread += nreadchunk = Buffer.Read(buffer, offset, chunkcount);
				Position += nreadchunk;
			}
			count -= chunkcount;
			offset += chunkcount;
		}
		return nread;
	}

	public override async Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		await GetSize();
		var size = await Size;
		// EOF guard
		if (Position >= size) return 0;

		int nread = 0, nreadchunk;
		while (count > 0 && offset < buffer.Length && Position < size)
		{
			var i = (int)(Position / ChunkSize);
			// safety: ensure i is in bounds
			if (i < 0 || i >= Chunks.Length) return nread;

			GetChunk(size, i);
			var chunk = Chunks[i];
			var posoffset = (int)(Position % ChunkSize);
			var bufpos = chunk.Position + posoffset;
			var chunkcount = Math.Min(count, ChunkSize - posoffset);
			if (Position + chunkcount > size) chunkcount = (int)(size - Position);
			if (chunkcount <= 0) break;
			await chunk.Data.Unwrap();
			using (var iolock = await IOLock.LockAsync())
			{
				if (Buffer == null) return 0;
				if (Buffer.Position != bufpos) Buffer.Seek(bufpos, SeekOrigin.Begin);
				nread += nreadchunk = await Buffer.ReadAsync(buffer, offset, chunkcount);
				Position += nreadchunk;
			}
			count -= chunkcount;
			offset += chunkcount;
		}
		return nread;
	}
	public override bool CanRead => true;
	public override bool CanWrite => false;
	public override bool CanSeek => true;
	public override bool CanTimeout => false;
	public override void Flush() { }
	public override Task FlushAsync(CancellationToken cancellationToken) => Task.CompletedTask;

	byte[] bytebuf = new byte[1];
	public override int ReadByte()
	{
		var nread = Read(bytebuf, 0, 1);
		return nread == 0 ? -1 : bytebuf[0];
	}
	public override long Seek(long offset, SeekOrigin origin)
	{
		switch (origin)
		{
			case SeekOrigin.Begin:
				Position = offset;
				break;
			case SeekOrigin.Current:
				Position += offset;
				break;
			case SeekOrigin.End:
				Position = Length + offset;
				break;
		}
		return Position;
	}
	public override void SetLength(long value)
	{
		throw new NotImplementedException();
	}
	public override void Write(byte[] buffer, int offset, int count)
	{
		throw new NotImplementedException();
	}
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		return base.WriteAsync(buffer, offset, count, cancellationToken);
	}

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		var task = ReadAsync(buffer, offset, count);
		task.ContinueWith(read => callback(read));
		return task;
	}
	public override int EndRead(IAsyncResult asyncResult)
	{
		asyncResult.AsyncWaitHandle.WaitOne();
		if (asyncResult is Task<int> task) return task.Result;
		else throw new InvalidOperationException("asnycResult must be a Task<int>.");
	}

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		throw new NotImplementedException();
	}
	public override void WriteByte(byte value)
	{
		throw new NotImplementedException();
	}
	public override void Close()
	{
		Dispose(true);
	}
	public override void EndWrite(IAsyncResult asyncResult)
	{
		throw new NotImplementedException();
	}
	protected override void Dispose(bool disposing)
	{
		const long MB = 1024 * 1024;
		using (var chlock = ChunkLock.Lock())
		using (var iolock = IOLock.Lock())
		{
			if (Buffer != null)
			{
				// capture name before disposing
				var bufferName = Buffer.Name;
				var size = Buffer.Length / MB;
				var totalTime = (DateTime.Now - Start).TotalSeconds;
				var download = DownloadTime.TotalSeconds;
				Log.Write($"Downloaded {size} MB at {((double)size) / download} MB/s, unpack speed {(double)size / totalTime} MB/s");
				Buffer.Dispose();
				try
				{
					if (IsTemp) System.IO.File.Delete(bufferName);
				}
				catch { }
				Buffer = null;
			}
		}
	}
}