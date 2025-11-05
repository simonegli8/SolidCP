using System;

namespace SolidCP.EnterpriseServer.Data;

interface IMigratableDbContext : IDisposable
{
	public void Migrate();
}
