﻿#if !Client
using System;
using System.Data;
using System.Web;
using System.Collections;
using System.Collections.Generic;
using SolidCP.Web.Services;
using System.ComponentModel;
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
    public interface IesTasks
    {
        [WebMethod]
        [OperationContract]
        BackgroundTask GetTask(string taskId);
        [WebMethod]
        [OperationContract]
        BackgroundTask GetTaskWithLogRecords(string taskId, DateTime startLogTime);
        [WebMethod]
        [OperationContract]
        int GetTasksNumber();
        [WebMethod]
        [OperationContract]
        List<BackgroundTask> GetUserTasks(int userId);
        [WebMethod]
        [OperationContract]
        List<BackgroundTask> GetUserCompletedTasks(int userId);
        [WebMethod]
        [OperationContract]
        void SetTaskNotifyOnComplete(string taskId);
        [WebMethod]
        [OperationContract]
        void StopTask(string taskId);
    }

    // wcf service
    [System.CodeDom.Compiler.GeneratedCodeAttribute("SolidCP.Build", "1.0")]
#if NETFRAMEWORK
[System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
#endif
    public class esTasks : SolidCP.EnterpriseServer.esTasks, IesTasks
    {
    }
}
#endif