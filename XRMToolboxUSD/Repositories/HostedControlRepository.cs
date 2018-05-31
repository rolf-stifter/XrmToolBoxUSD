using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using XRMToolboxUSD.Helpers;
using XRMToolboxUSD.Helpers.Enums;
using XRMToolboxUSD.Models;

namespace XRMToolboxUSD.Repositories
{
    public static class HostedControlRepository
    {
        public static List<USDHostedControl> GetHostedControls(IOrganizationService service)
        {
            QueryExpression hostedControlsQuery = new QueryExpression
            {
                EntityName = "uii_hostedapplication",
                ColumnSet = new ColumnSet(true),
                Criteria = new FilterExpression
                {
                },
                Orders =
                {
                    new OrderExpression
                    {
                        AttributeName = "uii_name",
                        OrderType = OrderType.Ascending
                    }
                }
            };

            return service.RetrieveMultiple(hostedControlsQuery).Entities.Select(x => ConvertEntityToHostedControl(x)).ToList();
        }

        private static USDHostedControl ConvertEntityToHostedControl(Entity entity)
        {
            return new USDHostedControl
            {
                Id = entity.GetAttributeValue<Guid>("uii_hostedapplicationid"),
                Name = entity.GetAttributeValue<string>("uii_name"),
                SortOrder = entity.GetAttributeValue<int>("uii_sortorder"),
                DisplayName = entity.GetAttributeValue<string>("msdyusd_displayname"),
                StateCode = (StateCode)entity.GetOptionSetValue("statecode"),
                ComponentType = (ComponentType)entity.GetOptionSetValue("msdyusd_crmwindowhosttype"),
                SavedURL = entity.GetAttributeValue<string>("msdyusd_savedurl"),
                PreFetchData = entity.GetAttributeValue<bool>("msdyusd_prefetchdata"),
                DashboardName = entity.GetAttributeValue<string>("msdyusd_dashboardname"),
                AllowMultiplePages = entity.GetAttributeValue<bool>("msdyusd_allowmultiplepages"),
                HostingType = (HostingType)entity.GetOptionSetValue("msdyusd_hostingtype"),
                MaximumBrowsers = entity.GetAttributeValue<int>("msdyusd_maximumbrowsers"),
                ScanForDataParameters = entity.GetAttributeValue<bool>("msdyusd_scanfordataparameters"),
                PanelType = (PanelType)entity.GetOptionSetValue("msdyusd_paneltype"),
                Xaml = entity.GetAttributeValue<string>("msdyusd_xaml"),
                HostedApplicationType = (HostedApplicationType)entity.GetOptionSetValue("uii_hostedapplicationtype"),
                ApplicationIsGlobal = entity.GetAttributeValue<bool>("uii_isglobalapplication"),
                DependentOnWorkflow = entity.GetAttributeValue<bool>("uii_isdependentonworkflow"),
                DisplayGroup = entity.GetAttributeValue<string>("uii_displaygroup"),
                MinimumX = entity.GetAttributeValue<int>("uii_minimumsizex"),
                MinimumY = entity.GetAttributeValue<int>("uii_minimumsizey"),
                OptimalX = entity.GetAttributeValue<int>("uii_optimalsizex"),
                OptimalY = entity.GetAttributeValue<int>("uii_optimalsizey"),
                Adapter = (Adapter)entity.GetOptionSetValue("uii_adaptermode"),
                URI = entity.GetAttributeValue<string>("uii_adapteruri"),
                Type = entity.GetAttributeValue<string>("uii_adaptertype"),
                ApplicationIsDynamic = entity.GetAttributeValue<bool>("uii_isappdynamic"),
                UserCanClose = entity.GetAttributeValue<bool>("uii_usercanclose"),
                ShowInToolbarDropdown = entity.GetAttributeValue<bool>("uii_isshowintoolbardropdown"),
                ExternalAppURI = entity.GetAttributeValue<string>("uii_externalappuri"),
                Arguments = entity.GetAttributeValue<string>("uii_externalapparguments"),
                WorkingDirectory = entity.GetAttributeValue<string>("uii_externalappworkingdirectory"),
                ManageHosting = entity.GetAttributeValue<bool>("uii_managehosting"),
                ApplicationHostingMode = (ApplicationHostingMode)entity.GetOptionSetValue("uii_applicationhostingmode"),
                AttachInputThread = entity.GetAttributeValue<bool>("uii_isattachinputthread"),
                ShowMenu = entity.GetAttributeValue<bool>("uii_isshowmenu"),
                NoMessagePump = entity.GetAttributeValue<bool>("uii_isnomessagepump"),
                MainWindowAcquisitionTimeout = entity.GetAttributeValue<int>("uii_mainwindowacquisitiontimeout"),
                TopLevelWindowMode = (WindowMode)entity.GetOptionSetValue("uii_toplevelwindowmode"),
                Caption = entity.GetAttributeValue<string>("uii_toplevelwindowcaption"),
                FindWindowClass = entity.GetAttributeValue<string>("uii_findwindowclass"),
                LimitToProcess = entity.GetAttributeValue<bool>("uii_islimittoprocess"),
                URL = entity.GetAttributeValue<string>("uii_webappurl"),
                UseToolbar = entity.GetAttributeValue<bool>("uii_iswebappusetoolbar"),
                UseNewBrowserProcess = entity.GetAttributeValue<bool>("uii_isusenewbrowserprocess"),
                ManagePopups = entity.GetAttributeValue<bool>("uii_managepopups"),
                AssemblyURI = entity.GetAttributeValue<string>("uii_assemblyuri"),
                AssemblyType = entity.GetAttributeValue<string>("uii_assemblytype"),
                RetainFrameAndCaption = entity.GetAttributeValue<bool>("uii_isretainframeandcaption"),
                RetainOnTaskbar = entity.GetAttributeValue<bool>("uii_isretainontaskbar"),
                RetainSystemMenu = entity.GetAttributeValue<bool>("uii_isretainsystemmenu"),
                RestoreIfMinimized = entity.GetAttributeValue<bool>("uii_isrestoreifminimized"),
                RemoveSizingControls = entity.GetAttributeValue<bool>("uii_removesizingcontrols"),
                ICAFileName = entity.GetAttributeValue<string>("uii_icafilename"),
                ProcessAcquisitionAttempts = entity.GetAttributeValue<int>("uii_remote_processacquisitionattempts"),
                ProcessAcquisitionDelay = entity.GetAttributeValue<int>("uii_remote_processacquisitiondelay"),
                ProcessAcquisitionFilename = entity.GetAttributeValue<string>("uii_processacquisitionfilename"),
                AutomationXML = entity.GetAttributeValue<string>("uii_automationxml"),
                ExtensionsXML = entity.GetAttributeValue<string>("uii_extensionsxml")
            };
        }
    }
}
