-- This is to upgrade from SolidCP .net to FuseCP CoreWCF

-- Removing Helicon Zoo
-- GroupID: 42
-- ProviderID: 135

DELETE FROM [HostingPlanQuotas] WHERE [QuotaID] = '600'
GO
DELETE FROM [Quotas] WHERE [GroupID] = '42'
GO
DELETE FROM [ServiceDefaultProperties] WHERE [ProviderID] = '1550'
GO
DELETE FROM [ServiceItemTypes] WHERE [GroupID] = '42'
GO
DELETE FROM [VirtualGroups] WHERE [GroupID] = '42' 
GO
DELETE FROM [dbo].[ResourceGroups] WHERE GroupID = '42'
GO
DELETE FROM [dbo].[Providers] WHERE ProviderID = 135
GO


-- Removing Microsoft Web Platform Installer (WebPI)
DELETE FROM [dbo].[SystemSettings] WHERE PropertyName = 'WpiSettings'
GO