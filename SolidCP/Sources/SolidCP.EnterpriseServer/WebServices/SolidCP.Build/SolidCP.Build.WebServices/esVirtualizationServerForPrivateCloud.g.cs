﻿#if !Client
using System;
using System.Data;
using System.Web;
using System.Collections;
using System.Collections.Generic;
using SolidCP.Web.Services;
using System.ComponentModel;
using SolidCP.Providers.Common;
using SolidCP.Providers.ResultObjects;
using SolidCP.Providers.Virtualization;
using SolidCP.EnterpriseServer;
#if NETFRAMEWORK
using System.ServiceModel;
#else
using CoreWCF;
#endif

namespace SolidCP.EnterpriseServer.Services
{
    // wcf service contract
    [WebService(Namespace = "http://smbsaas/solidcp/enterpriseserver")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [Policy("EnterpriseServerPolicy")]
    [ToolboxItem(false)]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("SolidCP.Build", "1.0")]
    [ServiceContract(Namespace = "http://smbsaas/solidcp/enterpriseserver/")]
    public interface IesVirtualizationServerForPrivateCloud
    {
        [WebMethod]
        [OperationContract]
        bool CheckServerState(VMForPCSettingsName control, string connString, string connName, int serviceId);
        [WebMethod]
        [OperationContract]
        VirtualMachineMetaItemsPaged GetVirtualMachines(int packageId, string filterColumn, string filterValue, string sortColumn, int startRow, int maximumRows, bool recursive);
        [WebMethod]
        [OperationContract]
        VirtualMachine[] GetVirtualMachinesByServiceId(int serviceId);
        [WebMethod]
        [OperationContract]
        VMInfo GetVirtualMachineItem(int itemId);
        [WebMethod]
        [OperationContract]
        string EvaluateVirtualMachineTemplate(int itemId, string template);
        [WebMethod]
        [OperationContract]
        NetworkAdapterDetails GetExternalNetworkDetails(int packageId);
        [WebMethod]
        [OperationContract]
        PrivateIPAddressesPaged GetPackagePrivateIPAddressesPaged(int packageId, string filterColumn, string filterValue, string sortColumn, int startRow, int maximumRows);
        [WebMethod]
        [OperationContract]
        List<PrivateIPAddress> GetPackagePrivateIPAddresses(int packageId);
        [WebMethod]
        [OperationContract]
        NetworkAdapterDetails GetPrivateNetworkDetails(int packageId);
        [WebMethod]
        [OperationContract]
        List<VirtualMachinePermission> GetSpaceUserPermissions(int packageId);
        [WebMethod]
        [OperationContract]
        int UpdateSpaceUserPermissions(int packageId, VirtualMachinePermission[] permissions);
        [WebMethod]
        [OperationContract]
        List<LogRecord> GetSpaceAuditLog(int packageId, DateTime startPeriod, DateTime endPeriod, int severity, string sortColumn, int startRow, int maximumRows);
        [WebMethod]
        [OperationContract]
        List<LogRecord> GetVirtualMachineAuditLog(int itemId, DateTime startPeriod, DateTime endPeriod, int severity, string sortColumn, int startRow, int maximumRows);
        [WebMethod]
        [OperationContract]
        LibraryItem[] GetOperatingSystemTemplatesPC(int packageId);
        [WebMethod]
        [OperationContract]
        LibraryItem[] GetHosts(int serviceId);
        [WebMethod]
        [OperationContract]
        LibraryItem[] GetClusters(int serviceId);
        [WebMethod]
        [OperationContract]
        LibraryItem[] GetOperatingSystemTemplatesByServiceId(int serviceId);
        [WebMethod]
        [OperationContract]
        int GetMaximumCpuCoresNumber(int packageId, string templateId);
        [WebMethod]
        [OperationContract]
        string GetDefaultExportPath(int itemId);
        [WebMethod]
        [OperationContract]
        ResultObject CreateVMFromVM(int packageId, VMInfo vmTemplate, string vmName);
        [WebMethod]
        [OperationContract]
        IntResult CreateVirtualMachine(int packageId, string hostname, string domain, string osTemplateFile, string vmName, string password, string summaryLetterEmail, int cpuCores, int ramMB, int hddGB, int snapshots, bool dvdInstalled, bool bootFromCD, bool numLock, bool startShutdownAllowed, bool pauseResumeAllowed, bool rebootAllowed, bool resetAllowed, bool reinstallAllowed, bool externalNetworkEnabled, string externalNetworkLocation, string externalNicMacAddress, string externalVirtualNetwork, bool privateNetworkEnabled, string privateNetworkLocation, string privateNicMacAddress, string privateVirtualNetwork, ushort privateVLanID);
        [WebMethod]
        [OperationContract]
        IntResult ImportVirtualMachine(int packageId, int serviceId, string vmId, string osTemplateFile, string adminPassword, bool startShutdownAllowed, bool pauseResumeAllowed, bool rebootAllowed, bool resetAllowed, bool reinstallAllowed, string externalNicMacAddress, int[] externalAddresses, string managementNicMacAddress, int managementAddress);
        [WebMethod]
        [OperationContract]
        byte[] GetVirtualMachineThumbnail(int itemId, ThumbnailSize size);
        [WebMethod]
        [OperationContract]
        VMInfo GetVirtualMachineGeneralDetails(int itemId);
        [WebMethod]
        [OperationContract]
        VirtualMachine GetVirtualMachineExtendedInfo(int serviceId, string vmId);
        [WebMethod]
        [OperationContract]
        int CancelVirtualMachineJob(string jobId);
        [WebMethod]
        [OperationContract]
        ResultObject UpdateVirtualMachineHostName(int itemId, string hostname, bool updateNetBIOS);
        [WebMethod]
        [OperationContract]
        ResultObject ChangeVirtualMachineState(int itemId, VirtualMachineRequestedState state);
        [WebMethod]
        [OperationContract]
        List<ConcreteJob> GetVirtualMachineJobs(int itemId);
        [WebMethod]
        [OperationContract]
        ResultObject ChangeAdministratorPassword(int itemId, string password);
        [WebMethod]
        [OperationContract]
        ResultObject UpdateVirtualMachineConfiguration(int itemId, int cpuCores, int ramMB, int hddGB, int snapshots, bool dvdInstalled, bool bootFromCD, bool numLock, bool startShutdownAllowed, bool pauseResumeAllowed, bool rebootAllowed, bool resetAllowed, bool reinstallAllowed, bool externalNetworkEnabled, bool privateNetworkEnabled);
        [WebMethod]
        [OperationContract]
        LibraryItem GetInsertedDvdDisk(int itemId);
        [WebMethod]
        [OperationContract]
        LibraryItem[] GetLibraryDisks(int itemId);
        [WebMethod]
        [OperationContract]
        ResultObject InsertDvdDisk(int itemId, string isoPath);
        [WebMethod]
        [OperationContract]
        ResultObject EjectDvdDisk(int itemId);
        [WebMethod]
        [OperationContract]
        VirtualMachineSnapshot[] GetVirtualMachineSnapshots(int itemId);
        [WebMethod]
        [OperationContract]
        VirtualMachineSnapshot GetSnapshot(int itemId, string snaphostId);
        [WebMethod]
        [OperationContract]
        ResultObject CreateSnapshot(int itemId);
        [WebMethod]
        [OperationContract]
        ResultObject ApplySnapshot(int itemId, string snapshotId);
        [WebMethod]
        [OperationContract]
        ResultObject RenameSnapshot(int itemId, string snapshotId, string newName);
        [WebMethod]
        [OperationContract]
        ResultObject DeleteSnapshot(int itemId, string snapshotId);
        [WebMethod]
        [OperationContract]
        ResultObject DeleteSnapshotSubtree(int itemId, string snapshotId);
        [WebMethod]
        [OperationContract]
        byte[] GetSnapshotThumbnail(int itemId, string snapshotId, ThumbnailSize size);
        [WebMethod]
        [OperationContract]
        void ConfigureCreatedVMNetworkAdapters(VMInfo vmInfo);
        [WebMethod]
        [OperationContract]
        NetworkAdapterDetails GetExternalNetworkAdapterDetails(int itemId);
        [WebMethod]
        [OperationContract]
        ResultObject AddVirtualMachineExternalIPAddresses(int itemId, bool selectRandom, int addressesNumber, int[] addressId);
        [WebMethod]
        [OperationContract]
        ResultObject SetVirtualMachinePrimaryExternalIPAddress(int itemId, int addressId);
        [WebMethod]
        [OperationContract]
        ResultObject DeleteVirtualMachineExternalIPAddresses(int itemId, int[] addressId);
        [WebMethod]
        [OperationContract]
        NetworkAdapterDetails GetPrivateNetworkAdapterDetails(int itemId);
        [WebMethod]
        [OperationContract]
        ResultObject AddVirtualMachinePrivateIPAddresses(int itemId, bool selectRandom, int addressesNumber, string[] addresses);
        [WebMethod]
        [OperationContract]
        ResultObject SetVirtualMachinePrimaryPrivateIPAddress(int itemId, int addressId);
        [WebMethod]
        [OperationContract]
        ResultObject DeleteVirtualMachinePrivateIPAddresses(int itemId, int[] addressId);
        [WebMethod]
        [OperationContract]
        List<VirtualMachinePermission> GetVirtualMachinePermissions(int itemId);
        [WebMethod]
        [OperationContract]
        int UpdateVirtualMachineUserPermissions(int itemId, VirtualMachinePermission[] permissions);
        [WebMethod]
        [OperationContract]
        VirtualSwitch[] GetExternalSwitches(int serviceId, string computerName);
        [WebMethod]
        [OperationContract]
        ResultObject DeleteVirtualMachine(int itemId, bool saveFiles, bool exportVps, string exportPath);
        [WebMethod]
        [OperationContract]
        int ReinstallVirtualMachine(int itemId, string adminPassword, bool preserveVirtualDiskFiles, bool saveVirtualDisk, bool exportVps, string exportPath);
        [WebMethod]
        [OperationContract]
        string GetVirtualMachineSummaryText(int itemId);
        [WebMethod]
        [OperationContract]
        ResultObject SendVirtualMachineSummaryLetter(int itemId, string to, string bcc);
        [WebMethod]
        [OperationContract]
        MonitoredObjectEvent[] GetDeviceEvents(int ItemID);
        [WebMethod]
        [OperationContract]
        MonitoredObjectAlert[] GetMonitoringAlerts(int ItemID);
        [WebMethod]
        [OperationContract]
        PerformanceDataValue[] GetPerfomanceValue(int ItemID, PerformanceType perf, DateTime startPeriod, DateTime endPeriod);
        [WebMethod]
        [OperationContract]
        VirtualNetworkInfo[] GetVirtualNetwork(int packageId);
    }

    // wcf service
    [System.CodeDom.Compiler.GeneratedCodeAttribute("SolidCP.Build", "1.0")]
#if NETFRAMEWORK
[System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
#endif
    public class esVirtualizationServerForPrivateCloud : SolidCP.EnterpriseServer.esVirtualizationServerForPrivateCloud, IesVirtualizationServerForPrivateCloud
    {
    }
}
#endif