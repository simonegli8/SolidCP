using System;
using System.Reflection;
using SolidCP.Providers;
using SolidCP.Providers.Web;
using SolidCP.Providers.OS;
using SolidCP.Providers.Utils;
using Ionic.Zip;
using System.Globalization;
using System.Security.Policy;
using System.Diagnostics.Contracts;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace SolidCP.UniversalInstaller
{


	public abstract class Installer
	{
		public const bool RunAsAdmin = true;
		public virtual string SolidCP => "SolidCP";
		public virtual string ServerFolder => "Server";
		public virtual string EnterpriseServerFolder => "EnterpriseServer";
		public virtual string PortalFolder => "Portal";
		public virtual string ServerUser => $"{SolidCP}Server";
		public virtual string EnterpriseServerUser => $"{SolidCP}EnterpriseServer";
		public virtual string WebPortalUser => $"{SolidCP}Portal";
		public virtual string SolidCPWebUsersGroup => "SCP_IUSRS";
		public virtual bool CanInstallServer => true;
		public virtual bool CanInstallEnterpriseServer => OSInfo.IsWindows;
		public virtual bool CanInstallPortal => OSInfo.IsWindows;
		static bool? hasDotnet = null;
		public virtual bool HasDotnet
		{
			get => hasDotnet ?? (hasDotnet = Shell.Find("dotnet") != null).Value;
			set => hasDotnet = value;
		}
		public bool NeedRemoveNet8Runtime = false;
		public bool NeedRemoveNet8AspRuntime = false;
		public virtual string? InstallWebRootPath { get; set; } = null;
		public virtual string? InstallExeRootPath { get; set; } = null;
		public abstract string WebsiteLogsPath { get; }

		public ServerSettings ServerSettings { get; set; } = new ServerSettings();
		public EnterpriseServerSettings EnterpriseServerSettings { get; set; } = new EnterpriseServerSettings();
		public WebPortalSettings WebPortalSettings { get; set; } = new WebPortalSettings();
		public int EstimatedOutputLines = 0;

		public Shell Shell { get; set; } = OSInfo.Current.DefaultShell.Clone;
		public Providers.OS.Installer OSInstaller => OSInfo.Current.DefaultInstaller;
		public IWebServer WebServer => OSInfo.Current.WebServer;
		public ServiceController ServiceController => OSInfo.Current.ServiceController;
		public UI UI => UI.Current;

		public void Log(string msg)
		{
			Console.WriteLine(msg);
			Shell.Log?.Invoke(msg);
		}

		bool firstCheck = true;
		public bool CheckNet8RuntimeInstalled()
		{
			if (!firstCheck) return true;
			firstCheck = false;

			if (HasDotnet)
			{
				var output = Shell.Exec("dotnet --info").Output().Result ?? "";
				NeedRemoveNet8AspRuntime = !output.Contains("Microsoft.AspNetCore.App 8.");
				NeedRemoveNet8Runtime = !output.Contains("Microsoft.NETCore.App 8.");
				return !NeedRemoveNet8Runtime && !NeedRemoveNet8AspRuntime;
			}
			else {
				NeedRemoveNet8Runtime = NeedRemoveNet8AspRuntime = true;
				return false;
			}
		}
		public abstract void InstallNet8Runtime();
		public abstract void RemoveNet8AspRuntime();
		public abstract void RemoveNet8NetRuntime();
		public virtual void RemoveNet8Runtime()
		{
			if (NeedRemoveNet8Runtime) RemoveNet8NetRuntime();
			if (NeedRemoveNet8AspRuntime) RemoveNet8AspRuntime();
		}

		public virtual void InstallServerPrerequisites() { }
		public virtual void InstallEnterpriseServerPrerequisites() { }
		public virtual void InstallPortalPrerequisites() { }
		public virtual void RemoveServerPrerequisites() { }
		public virtual void RemoveEnterpriseServerPrerequisites() { }
		public virtual void RemovePortalPrerequisites() { }


		public virtual void SetFilePermissions(string folder)
		{
			if (!Path.IsPathRooted(folder)) folder = Path.Combine(InstallWebRootPath, folder);

			if (!OSInfo.IsWindows)
			{
				((IUnixOperatingSystem)OSInfo.Current).GrantUnixPermissions(folder,
					Providers.OS.UnixFileMode.UserWrite | Providers.OS.UnixFileMode.GroupWrite |
					Providers.OS.UnixFileMode.UserRead | Providers.OS.UnixFileMode.GroupRead |
					Providers.OS.UnixFileMode.UserExecute | Providers.OS.UnixFileMode.GroupExecute, true);
			}
		}
		public virtual void SetServerFilePermissions() => SetFilePermissions(ServerFolder);
		public virtual void SetEnterpriseServerFilePermissions() => SetFilePermissions(EnterpriseServerFolder);
		public virtual void SetPortalFilePermissions() => SetFilePermissions(PortalFolder);

		public virtual void ConfigureServer()
		{
		}

		public virtual void InstallServer()
		{
			InstallServerPrerequisites();
			UnzipServer();
			InstallServerWebsite();
			SetServerFilePermissions();
			ConfigureServer();
		}

		public virtual void RemoveServer()
		{
			RemoveServerPrerequisites();
			RemoveServerFolder();
			RemoveServerWebsite();
		}

		public virtual void InstallWebsite(string name, string path, string urls, string username, string password)
		{

			// Create web users group
			if (!SecurityUtils.GroupExists(SolidCPWebUsersGroup, null, ""))
			{
				var group = new SystemGroup() { GroupName = SolidCPWebUsersGroup, Name = SolidCPWebUsersGroup };
				SecurityUtils.CreateGroup(group, null, "", "");
			}

			var site = new WebSite()
			{
				ContentPath = path,
				GroupName = SolidCPWebUsersGroup,
				AspNetInstalled = "v4.0",
				AnonymousUsername = username,
				AnonymousUserPassword = password,
				ApplicationPool = name,
				DedicatedApplicationPool = true,
				EnableAnonymousAccess = true,
				EnableBasicAuthentication = true,
				EnableDynamicCompression = false,
				EnableWritePermissions = true,
				Name = name,
				LogsPath = WebsiteLogsPath,
			};
			site.Bindings = urls
				.Split(';')
				.Select(url =>
				{
					url = url.Trim();
					var uri = new Uri(url);
					string ip = uri.Host;

					return new ServerBinding(uri.Scheme, "0.0.0.0", uri.Port.ToString(), uri.Host);
				})
				.ToArray();

			((HostingServiceProviderBase)WebServer).ProviderSettings.Settings.Add("WebGroupName", SolidCPWebUsersGroup);

			WebServer.CreateSite(site);
		}
		public virtual void InstallServerUser() { }
		public virtual void InstallServerApplicationPool() { }
		public virtual void InstallServerWebsite() { }
		public virtual void RemoveServerWebsite() { }
		public virtual void RemoveServerFolder() { }
		public virtual void RemoveServerUser() { }
		public virtual void RemoveServerApplicationPool() { }
		public virtual void InstallEnterpriseServer()
		{
			InstallEnterpriseServerPrerequisites();
			ReadEnterpriseServerConfiguration();
			UnzipEnterpriseServer();
			InstallEnterpriseServerWebsite();
			SetEnterpriseServerFilePermissions();
		}
		public virtual void InstallEnterpriseServerWebsite()
		{
			InstallWebsite($"{SolidCP}EnterpriseServer", 
				Path.Combine(InstallWebRootPath, EnterpriseServerFolder),
				EnterpriseServerSettings.Urls ?? "",
				"", "");

		}
		public virtual void InstallPortalWebsite()
		{
			InstallWebsite($"{SolidCP}WebPortal", Path.Combine(InstallWebRootPath, PortalFolder), WebPortalSettings.Urls ?? "", "", "");
		}
		public virtual void InstallWebPortal() {
			InstallPortalPrerequisites();
			ReadWebPortalConfiguration();
			UnzipPortal();
			InstallPortalWebsite();
			SetPortalFilePermissions();
		}
		public virtual void ReadServerConfiguration()
		{
			ServerSettings = new ServerSettings();
		}
		public virtual void ReadEnterpriseServerConfiguration()
		{
			EnterpriseServerSettings = new EnterpriseServerSettings();
		}
		public virtual void ReadWebPortalConfiguration()
		{
			WebPortalSettings = new WebPortalSettings();
		}

		public void ConfigureServer(ServerSettings settings)
		{
		}
		public void ConfigureEnterpriseServer(EnterpriseServerSettings settings)
		{

		}
		public void ConfigureWebPortal(WebPortalSettings settings)
		{

		}
		public virtual Func<string, string?>? UnzipFilter => null;
		public virtual void UnzipServer()
		{
			var websitePath = Path.Combine(InstallWebRootPath, ServerFolder);
			UnzipFromResource("SolidCP-Server.zip", websitePath, UnzipFilter);
		}
		public virtual void UnzipEnterpriseServer()
		{
			var websitePath = Path.Combine(InstallWebRootPath, EnterpriseServerFolder);
			UnzipFromResource("SolidCP-EnterpriseServer.zip", websitePath, UnzipFilter);
		}
		public virtual void UnzipPortal()
		{
			var websitePath = Path.Combine(InstallWebRootPath, PortalFolder);
			UnzipFromResource("SolidCP-Portal.zip", websitePath, Net48UnzipFilter);
		}

		public async Task<string> DownloadFileAsync(string url)
		{
			var web = new HttpClient();
			var tmp = Path.GetTempFileName();
			tmp = Path.ChangeExtension(tmp, Path.GetExtension(url));
			using (HttpResponseMessage response = await web.GetAsync(url))
			{
				if (response.StatusCode != System.Net.HttpStatusCode.OK) throw new Exception($"Could not download file {url}. Status code: {response.StatusCode}");

				using (Stream responseStream = await response.Content.ReadAsStreamAsync())
				using (var file = new FileStream(tmp, FileMode.Create, FileAccess.Write))
				{
					await responseStream.CopyToAsync(file);
				}
			}
			var name = Regex.Replace(url, @"(.*?/)|(?:\?.*$)", "", RegexOptions.Singleline);
			Log($"Downloaded file {name}{Environment.NewLine}");
			return tmp;
		}
		public string DownloadFile(string url) => DownloadFileAsync(url).Result;
		public string? Net48UnzipFilter(string file)
		{
			return (!file.StartsWith("Setup/") && !file.StartsWith("bin_dotnet/") && !file.EndsWith(".json")) ? file : null;
		}
		public string? Net8UnzipFilter(string file)
		{
			return (!file.StartsWith("Setup/") && (!file.StartsWith("bin/") || file.StartsWith("bin/netstandard/")) &&
				!file.EndsWith(".config", StringComparison.OrdinalIgnoreCase) && file != "appsettings.json" &&
				!file.EndsWith(".aspx") && !file.EndsWith(".asax")) ? file : null;
		}
		public void UnzipFromResource(string resourcePath, string destinationPath, Func<string, string?>? filter = null)
		{
			var assembly = Assembly.GetExecutingAssembly();
			var resourceName = assembly.GetManifestResourceNames()
				.FirstOrDefault(res => res.EndsWith(resourcePath, StringComparison.OrdinalIgnoreCase));

			if (resourceName == null) throw new NotSupportedException($"Cannot find {resourcePath} in resources.");

			Directory.CreateDirectory(destinationPath);

			using (var resource = assembly.GetManifestResourceStream(resourceName))
			using (var zip = ZipFile.Read(resource))
			{
				foreach (var zipEntry in zip)
				{
					var name = filter?.Invoke(zipEntry.FileName) ?? null;

					if (name != null)
					{
						var fullName = Path.Combine(destinationPath, name.Replace('/', Path.DirectorySeparatorChar));

						if (zipEntry.IsDirectory) Directory.CreateDirectory(fullName);
						else
						{
							var dir = Path.GetDirectoryName(fullName);
							if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

							using (var file = new FileStream(fullName, FileMode.Create, FileAccess.Write))
							{
								zipEntry.Extract(file);
							}
							Shell.Log?.Invoke($"Exracted {name}{Environment.NewLine}");
						}
					}
				}
			}
		}

		public virtual bool IsRunningAsAdmin() => true;
		public virtual void RestartAsAdmin() { }

		public void InstallAll()
		{
			const int EstimatedOutputLinesPerSite = 500;

			Shell.LogFile = "SolidCP.Installer.log";

			if (!IsRunningAsAdmin()) RestartAsAdmin();

			var packages = UI.GetPackagesToInstall();

			bool installServer = false, installEnterpriseServer = false, installPortal = false;

			try
			{
				if (CanInstallServer && packages.HasFlag(Packages.Server))
				{
					ReadServerConfiguration();
					ServerSettings = UI.GetServerSettings();
					EstimatedOutputLines += EstimatedOutputLinesPerSite;
					installServer = true;
				}

				if (CanInstallEnterpriseServer && packages.HasFlag(Packages.EnterpriseServer))
				{
					ReadEnterpriseServerConfiguration();
					EnterpriseServerSettings = UI.GetEnterpriseServerSettings();
					EstimatedOutputLines += EstimatedOutputLinesPerSite;
					installEnterpriseServer = true;
				}
				if (CanInstallPortal && packages.HasFlag(Packages.WebPortal))
				{
					ReadWebPortalConfiguration();
					WebPortalSettings = UI.GetWebPortalSettings();
					EstimatedOutputLines += EstimatedOutputLinesPerSite;
					installPortal = true;
				}

				if (installServer || installPortal || installEnterpriseServer) UI.ShowInstallationProgress();

				if (installServer) InstallServer();
				if (installEnterpriseServer) InstallEnterpriseServer();
				if (installPortal) InstallWebPortal();

				if (installServer || installPortal || installEnterpriseServer) UI.CloseInstallationProgress();
			}
			catch (Exception ex)
			{
				UI.ShowError(ex);

				Shell.Log($"Exception: {ex}");

				Console.WriteLine("Press any key to exit...");
				Console.Read();
			}
		}

		static Installer? current;
		public static Installer Current
		{
			get
			{
				if (current == null)
				{
					switch (OSInfo.OSFlavor)
					{
						case OSFlavor.Debian: current = new DebianInstaller(); break;
						// TODO support for Ubuntu variants
						// case OSFlavor.Mint:
						case OSFlavor.Ubuntu: current = new UbuntuInstaller(); break;
						case OSFlavor.RedHat: current = new RedHatInstaller(); break;
						case OSFlavor.CentOS: current = new CentOSInstaller(); break;
						case OSFlavor.Fedora: current = new FedoraInstaller(); break;
						case OSFlavor.Mac: current = new MacInstaller(); break;
						case OSFlavor.Windows: current = new WindowsInstaller(); break;
						case OSFlavor.Alpine: current = new AlpineInstaller(); break;
						case OSFlavor.SUSE: current = new SuseInstaller(); break;
						default: throw new PlatformNotSupportedException("This OS is not supported by the installer.");
					}
				}
				return current;
			}
		}
	}
}