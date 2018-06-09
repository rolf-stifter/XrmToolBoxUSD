using System.Collections.Generic;
using XRMToolboxUSD.Helpers.Enums;

namespace XRMToolboxUSD.Models.CRM
{
    public class HostedControl : USDEntity
    {
        #region General
        #region General
        public int SortOrder { get; set; }
        public string DisplayName { get; set; }
        #endregion

        #region USD
        public ComponentType ComponentType { get; set; }
        public string SavedURL { get; set; }
        public bool PreFetchData { get; set; }
        public string DashboardName { get; set; }
        public bool AllowMultiplePages { get; set; }
        public HostingType HostingType { get; set; }
        public int MaximumBrowsers { get; set; }
        public bool ScanForDataParameters { get; set; }
        #endregion

        #region Panel
        public PanelType PanelType { get; set; }
        public string Xaml { get; set; }
        #endregion

        #region  Hosted App Type
        public HostedApplicationType HostedApplicationType { get; set; }
        #endregion

        #region Common Properties
        public bool ApplicationIsGlobal { get; set; }
        public bool DependentOnWorkflow { get; set; }
        public string DisplayGroup { get; set; }
        public int MinimumX { get; set; }
        public int MinimumY { get; set; }
        public int OptimalX { get; set; }
        public int OptimalY { get; set; }
        #endregion

        #region Adapter Configuration
        public Adapter Adapter { get; set; }
        public string URI { get; set; }
        public string Type { get; set; }
        #endregion

        #region Dynamic
        public bool ApplicationIsDynamic { get; set; }
        public bool UserCanClose { get; set; }
        public bool ShowInToolbarDropdown { get; set; }
        #endregion
        #endregion

        #region Hosting
        #region External Application Settings
        public string ExternalAppURI { get; set; }
        public string Arguments { get; set; }
        public string WorkingDirectory { get; set; }
        public bool ManageHosting { get; set; }
        #endregion

        #region Application Hosting
        public ApplicationHostingMode ApplicationHostingMode { get; set; }
        public bool AttachInputThread { get; set; }
        public bool ShowMenu { get; set; }
        public bool NoMessagePump { get; set; }
        public int MainWindowAcquisitionTimeout { get; set; }
        #endregion

        #region Alternate Top Level Window
        public WindowMode TopLevelWindowMode { get; set; }
        public string Caption { get; set; }
        public string FindWindowClass { get; set; }
        public bool LimitToProcess { get; set; }
        #endregion

        #region Web Application Home Page
        public string URL { get; set; }
        public bool UseToolbar { get; set; }
        public bool UseNewBrowserProcess { get; set; }
        public bool ManagePopups { get; set; }
        #endregion

        #region Assembly Info
        public string AssemblyURI { get; set; }
        public string AssemblyType { get; set; }
        #endregion

        #region Dynamic Positioning Attributes
        public bool RetainFrameAndCaption { get; set; }
        public bool RetainOnTaskbar { get; set; }
        public bool RetainSystemMenu { get; set; }
        public bool RestoreIfMinimized { get; set; }
        public bool RemoveSizingControls { get; set; }
        #endregion

        #region Citrix Application Settings
        public string ICAFileName { get; set; }
        public int ProcessAcquisitionAttempts { get; set; }
        public int ProcessAcquisitionDelay { get; set; }
        public string ProcessAcquisitionFilename { get; set; }
        #endregion
        #endregion

        #region Automation
        #region Automation Bindings
        public string AutomationXML { get; set; }
        #endregion
        #endregion

        #region Extensions
        #region Extensions
        public string ExtensionsXML { get; set; }
        #endregion
        #endregion

        public List<Event> Events { get; set; }
    }
}