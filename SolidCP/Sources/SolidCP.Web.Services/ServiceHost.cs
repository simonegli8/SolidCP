﻿#if NETFRAMEWORK
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;
using System.ServiceModel.Channels;
using System.ServiceModel.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using SolidCP.Web.Services;

namespace SolidCP.Web.Services
{
	public enum Protocols { BasicHttp, BasicHttps, NetHttp, NetHttps, WSHttp, WSHttps, NetTcp, NetTcpSsl, gRPC, gRPCSsl, gRPCWeb, gRPCWebSsl, Assembly }

	public class ServiceHost : System.ServiceModel.ServiceHost
	{
		public ServiceHost() : base() { }
		public ServiceHost(Type serviceType, params Uri[] baseAdresses) : base(serviceType, baseAdresses)
		{
			AddEndpoints(serviceType, baseAdresses);
		}

		public ServiceHost(object singletonInstance, params Uri[] baseAdresses) : base(singletonInstance, baseAdresses)
		{
			AddEndpoints(singletonInstance.GetType(), baseAdresses);
		}

		bool HasApi(string adr, string api) => Regex.IsMatch(adr, $"{api}/[a-zA-Z0-9_]+(?:\\?|$)");
		bool IsHttp(string adr) => adr.StartsWith("http://", StringComparison.OrdinalIgnoreCase);
		bool IsHttps(string adr) => adr.StartsWith("https://", StringComparison.OrdinalIgnoreCase);
        bool IsNetTcp(string adr) => adr.StartsWith("net.tcp://", StringComparison.OrdinalIgnoreCase);
		bool IsPipe(string adr) => adr.StartsWith("pipe://", StringComparison.OrdinalIgnoreCase);


        void AddEndpoint(Type contract, Binding binding, string address)
		{
			binding.CloseTimeout = binding.OpenTimeout = binding.ReceiveTimeout = binding.SendTimeout = TimeSpan.FromMinutes(10);
			var endpoint = AddServiceEndpoint(contract, binding, address);
			endpoint.EndpointBehaviors.Add(new SoapHeaderMessageInspector());
		}

		void AddEndpoints(Type serviceType, Uri[] baseAdresses)
		{
			var contract = serviceType
				.GetInterfaces()
				.FirstOrDefault(i => i.GetCustomAttributes(false).OfType<ServiceContractAttribute>().Any());

			if (contract == null) throw new NotSupportedException();


			var policy = contract.GetCustomAttributes(false).OfType<PolicyAttribute>().FirstOrDefault();
			var isAuthenticated = policy != null;


			Credentials.UserNameAuthentication.UserNamePasswordValidationMode = UserNamePasswordValidationMode.Custom;
			Credentials.UserNameAuthentication.CustomUserNamePasswordValidator = new UserNamePasswordValidator() { Policy = policy };
			var behavior = Description.Behaviors.Find<ServiceDebugBehavior>();
			if (behavior != null) behavior.IncludeExceptionDetailInFaults = true;

			//Credentials.ServiceCertificate.SetCertificate(
			//	StoreLocation.LocalMachine, StoreName.My, X509FindType.FindBySubjectName, "localhost");

			foreach (var adr in baseAdresses.Select(uri => uri.AbsoluteUri)) {
				if (IsHttp(adr))
				{

					if (HasApi(adr, "basic"))
					{
						if (isAuthenticated)
						{
#if NETFRAMEWORK
							var binding = new BasicHttpBinding(BasicHttpSecurityMode.Message);
							AddEndpoint(contract, binding, adr);
#endif
						}
						else AddEndpoint(contract, new BasicHttpBinding(BasicHttpSecurityMode.None) { Name = "basic.none" }, adr);
					}
					else if (HasApi(adr, "net"))
					{
						if (isAuthenticated)
						{
#if NETFRAMEWORK
							var binding = new NetHttpBinding(BasicHttpSecurityMode.Message);
							AddEndpoint(contract, binding, adr);
#endif
						}
						else AddEndpoint(contract, new NetHttpBinding(BasicHttpSecurityMode.None) { Name = "net.none" }, adr);
					}
					else if (HasApi(adr, "ws"))
					{
						if (isAuthenticated)
						{
#if NETFRAMEWORK
							var binding = new WSHttpBinding(SecurityMode.Message);
							binding.Security.Message.ClientCredentialType = MessageCredentialType.None;
							binding.Security.Message.NegotiateServiceCredential = true;
							binding.Security.Message.EstablishSecurityContext = true;
							binding.Name = "ws.message";
							AddEndpoint(contract, binding, adr);
#endif
						}
						else AddEndpoint(contract, new WSHttpBinding(SecurityMode.None) { Name = "ws.none" }, adr);
					}
					else
					{
						if (isAuthenticated)
						{
#if NETFRAMEWORK
							var binding = new WSHttpBinding(SecurityMode.Message);
							binding.Security.Message.NegotiateServiceCredential = true;
							binding.Security.Message.ClientCredentialType = MessageCredentialType.None;
							binding.Security.Message.EstablishSecurityContext = true;
							binding.Name = "ws.message";
							AddEndpoint(contract, binding, adr);
#endif
						}
						else AddEndpoint(contract, new BasicHttpBinding(BasicHttpSecurityMode.None) { Name = "net.none" }, adr);
					}
				}
				else if (IsHttps(adr))
				{
					if (HasApi(adr, "basic"))
					{
						if (isAuthenticated)
						{
							var binding = new BasicHttpBinding(BasicHttpSecurityMode.Transport);
							binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
							binding.Name = "basic.transportwithmessage";
							AddEndpoint(contract, binding, adr);
						}
						else
						{
							var binding = new BasicHttpBinding(BasicHttpSecurityMode.Transport);
							binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
							binding.Name = "basic.transport";
							AddEndpoint(contract, binding, adr);
						}
					}
					else if (HasApi(adr, "ws"))
					{
						if (isAuthenticated)
						{
							var binding = new WSHttpBinding(SecurityMode.Transport);
							binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
							binding.Name = "ws.transportwithmessage";
							AddEndpoint(contract, binding, adr);
						}
						else
						{
							var binding = new WSHttpBinding(SecurityMode.Transport);
							binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
							binding.Name = "ws.transportwithmessage";
							AddEndpoint(contract, binding, adr);
						}
					}
					else if (HasApi(adr, "net"))
					{
						if (isAuthenticated)
						{
							var binding = new NetHttpBinding(BasicHttpSecurityMode.Transport);
							binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
							binding.Name = "net.transportwithmessage";
							AddEndpoint(contract, binding, adr);
						}
						else
						{
							var binding = new NetHttpBinding(BasicHttpSecurityMode.Transport);
							binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
							binding.Name = "net.transport";
							AddEndpoint(contract, binding, adr);
						}
					}
					else
					{
						if (isAuthenticated)
						{
							var binding = new BasicHttpBinding(BasicHttpSecurityMode.Transport);
							binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
							binding.Name = "basic.transport";
							AddEndpoint(contract, binding, adr);
						}
						else
						{
							var binding = new BasicHttpBinding(BasicHttpSecurityMode.Transport);
							binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
							binding.Name = "basic.transport";
							AddEndpoint(contract, binding, adr);
						}
					}
				}

                else if (adr.StartsWith("net.tcp://", StringComparison.OrdinalIgnoreCase))
				{
					if (HasApi(adr, "nettcp"))
					{
						if (isAuthenticated)
						{
							var binding = new NetTcpBinding(SecurityMode.Transport);
							binding.Security.Transport.ClientCredentialType = TcpClientCredentialType.None;
							binding.Name = "nettcp.transportwithmessage";
							AddEndpoint(contract, binding, adr);
						} else AddEndpoint(contract, new NetTcpBinding(SecurityMode.None) {  Name="nettcp.none" }, adr);
					}
				}
				else if (adr.StartsWith("net.pipe://", StringComparison.OrdinalIgnoreCase))
				{
					if (HasApi(adr, "pipe"))
					{
						if (isAuthenticated) AddEndpoint(contract, new NetNamedPipeBinding(NetNamedPipeSecurityMode.Transport) { Name="pipe.transport" }, adr);
						else AddEndpoint(contract, new NetNamedPipeBinding(NetNamedPipeSecurityMode.None) { Name="pipe.none" }, adr);
					}
				}

				var meta = Description.Behaviors.OfType<ServiceMetadataBehavior>().FirstOrDefault();
				if (meta == null)
				{
					meta = new ServiceMetadataBehavior();
					Description.Behaviors.Add(meta);
				}
				if (IsHttp(adr)) meta.HttpGetEnabled = true;
				else if (IsHttps(adr)) meta.HttpsGetEnabled = true;

				meta.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;

				/* if (IsHttp(adr)) AddServiceEndpoint(ServiceMetadataBehavior.MexContractName, MetadataExchangeBindings.CreateMexHttpBinding(), $"{adr}/mex");
				if (IsHttps(adr)) AddServiceEndpoint(ServiceMetadataBehavior.MexContractName, MetadataExchangeBindings.CreateMexHttpsBinding(), $"{adr}/mex");
				if (IsNetTcp(adr)) AddServiceEndpoint(ServiceMetadataBehavior.MexContractName, MetadataExchangeBindings.CreateMexTcpBinding(), $"{adr}/mex");
				if (IsPipe(adr)) AddServiceEndpoint(ServiceMetadataBehavior.MexContractName, MetadataExchangeBindings.CreateMexNamedPipeBinding(), $"{adr}/mex");
				*/
            }
		}

	}
}
#endif