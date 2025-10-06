using SolidCP.Providers.OS;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SolidCP.EnterpriseServer.Data;

public class DynamicLibraries
{
	private static void AddEnvironmentPaths(params IEnumerable<string> newpaths)
	{
		var path = new[] { Environment.GetEnvironmentVariable("PATH") ?? string.Empty };
		newpaths = newpaths.Select(path => SolidCP.Web.Services.Server.MapPath(path));
		var newpath = string.Join(Path.PathSeparator.ToString(), path.Concat(newpaths));

		Environment.SetEnvironmentVariable("PATH", newpath);
	}
	public static bool IsLinuxMusl
	{
		get
		{
			if (!OSInfo.IsLinux) return false;

			var info = new ProcessStartInfo("ldd");
			info.Arguments = "/bin/ls";
			info.RedirectStandardOutput = true;
			info.UseShellExecute = false;
			var p = Process.Start(info);
			return p.StandardOutput.ReadToEnd().Contains("musl");
		}
	}

	public static void Init()
	{
#if NETCOREAPP
		var arch = RuntimeInformation.ProcessArchitecture.ToString().ToLower();
		if (arch == "x64" && IsLinuxMusl) arch = "musl-x64";
		var os = OSInfo.IsWindows ? "win" : OSInfo.IsMac ? "osx" : "linux";
		AddEnvironmentPaths($"~/bin_dotnet/runtime/{os}/native", $"~/bin_dotnet/runtime/{os}-{arch}/native");
#endif
	}
}
