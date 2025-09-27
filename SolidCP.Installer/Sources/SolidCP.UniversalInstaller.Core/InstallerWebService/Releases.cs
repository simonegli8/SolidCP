using Nito.AsyncEx;
using Octokit;
using SharpCompress.Archives;
using SharpCompress.Archives.SevenZip;
using SharpCompress.Common;
using SharpCompress.Readers;
using SolidCP.Providers.EnterpriseStorage;
using SolidCP.UniversalInstaller.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Security.Policy;
using System.Text;

namespace SolidCP.UniversalInstaller;

public class Releases
{
	public GitHubReleases GitHub => Installer.Current.GitHub;
	public IInstallerWebService WebService = Installer.Current.InstallerWebService;

	public const long ChunkSize = 262144;

	public CancellationTokenSource Cancel = new CancellationTokenSource();

	public static AsyncLock Lock = new AsyncLock();
	public ComponentUpdateInfo GetComponentUpdate(string componentCode, string release)
		=> GetComponentUpdateAsync(componentCode, release).Result;
	public async Task<ComponentUpdateInfo> GetComponentUpdateAsync(string componentCode, string release)
	{
		using (var alock = await Lock.LockAsync())
		{
			var infos = new[] {
				GitHub.GetComponentUpdateAsync(componentCode, release),
				WebService.GetComponentUpdateAsync(componentCode, release)
			};
			var info = await infos[0];
			if (info == null) return await infos[1];
			return info;
		}
	}
	public List<ComponentInfo> GetAvailableComponents() => GetAvailableComponentsAsync().Result;
	public async Task<List<ComponentInfo>> GetAvailableComponentsAsync()
	{
		using (var alock = await Lock.LockAsync()) {
			var components = new[]
			{
				GitHub.GetAvailableComponentsAsync(),
				WebService.GetAvailableComponentsAsync()
			};
			await Task.WhenAll(components);
			var ghcomponents = await components[0];
			var wscomponents = await components[1];
			if (ghcomponents != null && ghcomponents.Count > 0 &&
				(wscomponents == null || wscomponents.Count == 0 ||
				ghcomponents[0].Version > wscomponents[0].Version)) return ghcomponents;
			else return wscomponents;
		}
	}
	public ComponentUpdateInfo GetLatestComponentUpdate(string componentCode) =>
		GetLatestComponentUpdateAsync(componentCode).Result;
	public async Task<ComponentUpdateInfo> GetLatestComponentUpdateAsync(string componentCode)
	{
		using (var alock = await Lock.LockAsync())
		{
			var infos = new[]
			{
				GitHub.GetLatestComponentUpdateAsync(componentCode),
				WebService.GetLatestComponentUpdateAsync(componentCode)
			};
			var ghinfo = await infos[0];
			var wsinfo = await infos[1];
			if (ghinfo != null &&
				(wsinfo == null || ghinfo.Version > wsinfo.Version)) return ghinfo;
			else return wsinfo;
		}
	}
	public ComponentUpdateInfo GetReleaseFileInfo(string componentCode, string version) =>
		GetReleaseFileInfoAsync(componentCode, version).Result;

	public async Task<ComponentUpdateInfo> GetReleaseFileInfoAsync(string componentCode, string version)
	{
		using (var alock = await Lock.LockAsync())
		{
			var infos = new[]
			{
				GitHub.GetReleaseFileInfoAsync(componentCode, version),
				WebService.GetReleaseFileInfoAsync(componentCode, version)
			};
			var info = await infos[0] ?? await infos[1];
			return info != null ? new ComponentUpdateInfo(info, version) : null;
		}
	}

	public async Task<string> GetDownloadUrlAsync(RemoteFile file)
	{
		if (!string.IsNullOrEmpty(file.DownloadUrl)) return file.DownloadUrl;
		if (file.Release?.GitHub == true) return await GitHub.GetDownloadUrl(file);
		else
		{
			var uri = new Uri(WebService.Url);
			return file.File.Replace("~", $"{uri.Scheme}://{uri.Authority}");
		}
    }
	HttpClientHandler ProxyHandler()
	{
		if (Installer.Current.Settings.Installer.Proxy != null && !string.IsNullOrEmpty(Installer.Current.Settings.Installer.Proxy.Address))
		{
			var settings = Installer.Current.Settings.Installer.Proxy;
			var proxy = new WebProxy(settings.Address, false);  // proxy address + port
			if (!string.IsNullOrEmpty(settings.Username) && !string.IsNullOrEmpty(settings.Password))
			{
				proxy.Credentials = new NetworkCredential(settings.Username, settings.Password); // if proxy needs auth
			}

			// Attach proxy to handler
			return new HttpClientHandler
			{
				Proxy = proxy,
				UseProxy = true
			};
		}
		return null;
	}
	public async Task<byte[]> DownloadFileChunkAsync(string url, long offset, long length)
	{
		var handler = ProxyHandler();
		using var client = handler != null ? new HttpClient(handler) : new HttpClient();
		client.DefaultRequestHeaders.Range = new System.Net.Http.Headers.RangeHeaderValue(offset, offset + length);
		using var response = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);
		response.EnsureSuccessStatusCode();
		return await response.Content.ReadAsByteArrayAsync();
	}
	public async Task<long> GetFileSizeAsync(string url)
	{
		var handler = ProxyHandler();
		using var client = handler != null ? new HttpClient(handler) : new HttpClient();
		var request = new HttpRequestMessage(HttpMethod.Head, url);
		using var response = await client.SendAsync(request);
		response.EnsureSuccessStatusCode();
		return response.Content.Headers.ContentLength ?? -1;
	}

	public void GetFile(RemoteFile file, string destinationFile, Action<long, long> progress = null) =>
		Task.Run(() => GetFileAsync(file, destinationFile, progress)).Wait();
	public async Task GetFileAsync(RemoteFile file, string destinationFile, Action<long, long> progress = null)
	{
		using (var alock = await Lock.LockAsync())
		{
			if (file.Release?.GitHub == true) await GitHub.GetFileAsync(file, destinationFile, progress);
			else
			{
				var url = await GetDownloadUrlAsync(file);

				var destinationPath = Path.GetDirectoryName(destinationFile);
				if (!Directory.Exists(destinationPath)) Directory.CreateDirectory(destinationPath);

				long downloaded = 0;
				long fileSize = await GetFileSizeAsync(url);

				if (fileSize == 0)
				{
					throw new FileNotFoundException("Service returned empty file.", file.File);
				}

				byte[] content;

				while (downloaded < fileSize)
				{
					// Throw OperationCancelledException if there is an incoming cancel request
					Installer.Current.Cancel.Token.ThrowIfCancellationRequested();

					content = await DownloadFileChunkAsync(url, downloaded, ChunkSize);
					if (content == null)
					{
						throw new FileNotFoundException("Service returned NULL file content.", file.File);
					}
					FileUtils.AppendFileContent(destinationFile, content);

					downloaded += content.Length;

					progress?.Invoke(downloaded, fileSize);

					if (content.Length < ChunkSize)
						break;
				}
			}
		}
	}
	public async Task GetFileAndUnzipAsync(RemoteFile file, string destinationFile, string destinationPath, Func<string, bool> filter = null, 
		Action<long, long> progress = null)
	{
		using (var alock = await Lock.LockAsync())
		{
			var url = await GetDownloadUrlAsync(file);

			if (string.IsNullOrEmpty(destinationPath)) destinationPath = Path.GetDirectoryName(destinationFile);
			if (!Directory.Exists(destinationPath)) Directory.CreateDirectory(destinationPath);

			if (url.EndsWith(".7z", StringComparison.OrdinalIgnoreCase) ||
				url.EndsWith(".zip", StringComparison.OrdinalIgnoreCase))
			{
				using (var stream = new SeekableDownloadStream(this, url, destinationFile + ".tmp", true))
				{
					UnzipFile(destinationFile, destinationPath, filter, stream, progress);
				}
			}
			else
			{
				using (var stream = new SeekableDownloadStream(this, url, destinationFile, false, progress))
				{
					await stream.DownloadComplete;
				}
			}
        }
	}
	public void UnzipFile(string zipFile, string destFolder, Func<string, bool> filter = null, Stream stream = null,
	Action<long, long> progress = null)
	{
		if (zipFile.EndsWith(".7z")) Unzip7zFile(zipFile, destFolder, filter, stream, progress);
		else UnzipZipFile(zipFile, destFolder, filter, stream, progress);
	}
	public void Unzip7zFile(string zipFile, string destFolder, Func<string, bool> filter = null, Stream stream = null,
		Action<long, long> progress = null)
	{
		try
		{
			if (filter == null) filter = name => true;

			Log.WriteStart("Unzipping file");
			Log.WriteInfo(string.Format("Unzipping file \"{0}\" to the folder \"{1}\"", zipFile, destFolder));

			using (var file = stream ?? new FileStream(zipFile, System.IO.FileMode.Open, FileAccess.Read))
			using (var zip = SevenZipArchive.Open(file))
			{
				long zipSize = file.Length;
				long unzipped = 0;

				int files = 0;

				var reader = zip.ExtractAllEntries();
				while (reader.MoveToNextEntry())
				{
					if (Cancel.IsCancellationRequested) break;

					if (filter(reader.Entry.Key) && !reader.Entry.IsDirectory)
					{
						reader.WriteEntryToDirectory(destFolder, new ExtractionOptions() { ExtractFullPath = true, Overwrite = true });
						files++;
						unzipped += reader.Entry.CompressedSize;

						if (zipSize != 0)
						{
							progress?.Invoke(unzipped, zipSize);
						}
					}
				}

				Installer.Current.Files = files;

				progress?.Invoke(zipSize, zipSize);
				Log.WriteEnd("Unzipped file");
			}
		}
		catch (Exception ex)
		{
			if (ex is ThreadAbortException)
				return;

			throw;
		}
	}
	private void UnzipZipFile(string zipFile, string destFolder, Func<string, bool> filter = null, Stream stream = null,
		Action<long, long> progress = null)
	{
		try
		{
			if (filter == null) filter = name => true;

			Log.WriteStart("Unzipping file");
			Log.WriteInfo(string.Format("Unzipping file \"{0}\" to the folder \"{1}\"", zipFile, destFolder));

			using (var file = stream ?? new FileStream(zipFile, System.IO.FileMode.Open, FileAccess.Read))
			using (var zip = new ZipArchive(file))
			{
				long zipSize = file.Length;
				long unzipped = 0;

				int files = 0;

				foreach (var entry in zip.Entries)
				{
					if (Cancel.IsCancellationRequested) break;

					if (filter(entry.FullName))
					{
						if (string.IsNullOrEmpty(entry.Name))
						{
							Directory.CreateDirectory(Path.Combine(destFolder, entry.FullName.Replace('/', Path.DirectorySeparatorChar)));
						}
						else
						{
							entry.ExtractToFile(Path.Combine(destFolder, entry.FullName.Replace('/', Path.DirectorySeparatorChar)), true);
							files++;
						}
					}
					else if (!string.IsNullOrEmpty(entry.Name)) files++;

					unzipped += entry.CompressedLength;

					if (zipSize != 0) progress?.Invoke(unzipped, zipSize);
				}

				Installer.Current.Files = files;

				progress?.Invoke(zipSize, zipSize);

				Log.WriteEnd("Unzipped file");
			}
		}
		catch (Exception ex)
		{
			if (ex is ThreadAbortException)
				return;
			throw;
		}
	}

	public void AbortOperation()
	{
		if (Cancel != null) Cancel.Cancel();
	}

}
