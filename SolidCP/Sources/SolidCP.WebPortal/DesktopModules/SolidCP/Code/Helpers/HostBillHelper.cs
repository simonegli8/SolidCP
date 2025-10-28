using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidCP.Portal.Code.Helpers
{
	public class HostBillHelper
	{
		public static void SetHostBillIntegration(bool enabled, string id, string key, string url)
		{
			ES.Services.System.SetHostBillIntegration(enabled, url);
		}

		public static void GetHostBillIntegration(out bool enabled, out string url)
		{
			url = ES.Services.System.GetHostBillIntegration();
			enabled = !string.IsNullOrEmpty(url);
		}


	}
}
