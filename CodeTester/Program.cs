using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using XRMToolboxUSD.Logic;
using XRMToolboxUSD.Models;
using XRMToolboxUSD.Repositories;

namespace CodeTester
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {

                IOrganizationService Service = CreateIOrganizationService(@"dev01@labx.bdbelux.be", @"-HXIAA#S0a#k!m\P", @"https://bdlabx-lmes-25-dev.api.crm4.dynamics.com/XRMServices/2011/Organization.svc");

                var usdConfigData = new USDConfigurationData();

                usdConfigData.HostedControls = HostedControlRepository.GetHostedControls(Service);
                usdConfigData.Events = EventRepository.GetEvents(Service);
                usdConfigData.Actions = ActionRepository.GetActions(Service);
                usdConfigData.EventActionConnections = EventActionConnectionRepository.GetEventActionConnections(Service);
                usdConfigData.ActionSubActionConnections = ActionSubActionRepository.GetActionSubActionConnections(Service);

                var usdTree = USDTree.GenerateUSDTree(usdConfigData);
                PrintUSDTree(usdTree);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw;
            }
        }

        private static IOrganizationService CreateIOrganizationService(string username, string password, string organizationURL)
        {
            ClientCredentials clientCredentials = new ClientCredentials();
            clientCredentials.UserName.UserName = username;
            clientCredentials.UserName.Password = password;

            // For Dynamics 365 Customer Engagement V9.X, set Security Protocol as TLS12
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            // Get the URL from CRM, Navigate to Settings -> Customizations -> Developer Resources
            // Copy and Paste Organization Service Endpoint Address URL
            IOrganizationService organizationService = (IOrganizationService)new OrganizationServiceProxy(new Uri(organizationURL),
             null, clientCredentials, null);

            if (organizationService != null)
            {
                Guid userid = ((WhoAmIResponse)organizationService.Execute(new WhoAmIRequest())).UserId;

                if (userid != Guid.Empty)
                {
                    Console.WriteLine("Connection Established Successfully...");
                }
            }
            else
            {
                Console.WriteLine("Failed to Established Connection!!!");
            }

            return organizationService;
        }

        private static void PrintUSDTree(List<USDHostedControl> hostedControls)
        {
            foreach (var usdHostedControl in hostedControls)
            {
                Console.WriteLine(usdHostedControl.Name);
                foreach (var usdEvent in usdHostedControl.Events)
                {
                    Console.WriteLine($"\t{usdEvent.Name}");
                    foreach (var usdAction in usdEvent.Actions)
                    {
                        Console.WriteLine($"\t\t{usdAction.Name}");
                        PrintSubActions(usdAction);
                    }

                }
            }
        }
        private static void PrintSubActions(USDAction usdAction)
        {
            foreach (var usdSubAction in usdAction.SubActions)
            {
                Console.WriteLine($"\t\t\t{usdSubAction.Name}");
                PrintSubActions(usdSubAction);
            }
        }
    }
}
