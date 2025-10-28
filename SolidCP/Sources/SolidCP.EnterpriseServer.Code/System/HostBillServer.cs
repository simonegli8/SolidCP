using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidCP.EnterpriseServer;


public class HostBillServer: HostBillServerInfo
{
	SystemController SystemController;
	public void SyncHostBillUsers()
	{
	}

	public HostBillUserInfo GetHostBillUser(string username)
	{
		var server = GetHostBillIntegration();
		if (!server.Enabled) return null;
	}

	public void CreateHostBillUser(HostBillServerInfo user) { }

	public int LoginHostBillUser(string username, string password)
	{
		var server = GetHostBillIntegration();
		if (!server.Enabled) return BusinessErrorCodes.ERROR_USER_NOT_FOUND;

		var user = GetHostBillUser(username);
	}

}
