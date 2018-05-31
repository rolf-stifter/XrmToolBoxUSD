using Microsoft.Xrm.Sdk;
using System;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using XRMToolboxUSD.Models;

namespace XRMToolboxUSD.UserControls
{
    public partial class HostedControlDetails : UserControl
    {
        public HostedControlDetails()
        {
            InitializeComponent();
        }

        public void FillDetails(USDHostedControl usdHostedControl)
        {
            if (usdHostedControl == null) return;

            textBox_name.Text = usdHostedControl.Name;
            textBox_id.Text = usdHostedControl.Id.ToString();
            textBox_sortOrder.Text = usdHostedControl.SortOrder.ToString();
            textBox_displayName.Text = usdHostedControl.DisplayName;
            textBox_usdComponentType.Text = usdHostedControl.ComponentType.ToString();
            textBox_savedURL.Text = usdHostedControl.SavedURL;
            checkBox_preFetchData.Checked = usdHostedControl.PreFetchData;
            textBox_dashboardName.Text = usdHostedControl.DashboardName;
            checkBox_allowMultiplePages.Checked = usdHostedControl.AllowMultiplePages;
            textBox_hostingType.Text = usdHostedControl.HostingType.ToString();
            textBox_maximumBrowsers.Text = usdHostedControl.MaximumBrowsers.ToString();
            checkBox_scanForDataParameters.Checked = usdHostedControl.ScanForDataParameters;
            textBox_panelType.Text = usdHostedControl.PanelType.ToString();
            textBox_XAML.Text = usdHostedControl.Xaml;
            textBox_hostedAppType.Text = usdHostedControl.HostedApplicationType.ToString();
            checkBox_appIsGlobal.Checked = usdHostedControl.ApplicationIsGlobal;
            checkBox_dependentOnWorkflow.Checked = usdHostedControl.DependentOnWorkflow;
            textBox_displayGroup.Text = usdHostedControl.DisplayGroup;
            textBox_minimumX.Text = usdHostedControl.MinimumX.ToString();
            textBox_minimumY.Text = usdHostedControl.MinimumY.ToString();
            textBox_optimalX.Text = usdHostedControl.OptimalX.ToString();
            textBox_optimalY.Text = usdHostedControl.OptimalY.ToString();
            textBox_adapter.Text = usdHostedControl.Adapter.ToString();
            textBox_uri.Text = usdHostedControl.URI;
            textBox_type.Text = usdHostedControl.Type;
            checkBox_applicationDynamic.Checked = usdHostedControl.ApplicationIsDynamic;
            checkBox_userCanClose.Checked = usdHostedControl.UserCanClose;
            checkBox_showInToolbarDropdown.Checked = usdHostedControl.ShowInToolbarDropdown;
            textBox_externalAppURI.Text = usdHostedControl.ExternalAppURI;
            textBox_arguments.Text = usdHostedControl.Arguments;
            textBox_workingDirectory.Text = usdHostedControl.WorkingDirectory;
            checkBox_manageHosting.Checked = usdHostedControl.ManageHosting;
            textBox_applicationHostingMode.Text = usdHostedControl.ApplicationHostingMode.ToString();
            checkBox_attachInputThread.Checked = usdHostedControl.AttachInputThread;
            checkBox_showMenu.Checked = usdHostedControl.ShowMenu;
            checkBox_noMessagePump.Checked = usdHostedControl.NoMessagePump;
            textBox_mainWindowAcquisitionTimeout.Text = usdHostedControl.MainWindowAcquisitionTimeout.ToString();
            textBox_topLevelWindowMode.Text = usdHostedControl.TopLevelWindowMode.ToString();
            textBox_caption.Text = usdHostedControl.Caption;
            textBox_findWindowClass.Text = usdHostedControl.FindWindowClass;
            checkBox_limitToProcess.Checked = usdHostedControl.LimitToProcess;
            textBox_url.Text = usdHostedControl.URL;
            checkBox_useToolbar.Checked = usdHostedControl.UseToolbar;
            checkBox_useNewBrowserProcess.Checked = usdHostedControl.UseNewBrowserProcess;
            checkBox_managePopups.Checked = usdHostedControl.ManagePopups;
            textBox_assemblyURI.Text = usdHostedControl.AssemblyURI;
            textBox_assemblyType.Text = usdHostedControl.AssemblyType;
            checkBox_retainFrameAndCaption.Checked = usdHostedControl.RetainFrameAndCaption;
            checkBox_retainOnTaskbar.Checked = usdHostedControl.RetainOnTaskbar;
            checkBox_retainSystemMenu.Checked = usdHostedControl.RetainSystemMenu;
            checkBox_restoreIfMinimized.Checked = usdHostedControl.RestoreIfMinimized;
            checkBox_removeSizingControls.Checked = usdHostedControl.RemoveSizingControls;
            textBox_icaFileName.Text = usdHostedControl.ICAFileName;
            textBox_processAcquisitionAttempts.Text = usdHostedControl.ProcessAcquisitionAttempts.ToString();
            textBox_processAcquisitionDelay.Text = usdHostedControl.ProcessAcquisitionDelay.ToString();
            textBox_processAcquisitionFilename.Text = usdHostedControl.ProcessAcquisitionFilename;
            textBox_automationXML.Text = usdHostedControl.AutomationXML;
            textBox_extensionsXML.Text = usdHostedControl.ExtensionsXML;

            //Set Link in tag
            linkLabel_url.Tag = $"{Helpers.GlobalProperties.WebApplicationUrl}main.aspx?etn=uii_hostedapplication&id={{{usdHostedControl.Id }}}&pagetype=entityrecord";
        }

        private void linkLabel_url_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start((string)((LinkLabel)sender).Tag);
        }

        private void label_expanderGeneral_Click(object sender, EventArgs e)
        {
            var expanderLabel = (System.Windows.Forms.Label)sender;
            Helpers.Layout.SetInverseVisibility(expanderLabel);
        }

        private void label_expanderHosting_Click(object sender, EventArgs e)
        {
            var expanderLabel = (System.Windows.Forms.Label)sender;
            Helpers.Layout.SetInverseVisibility(expanderLabel);
        }

        private void label_expanderAutomation_Click(object sender, EventArgs e)
        {
            var expanderLabel = (System.Windows.Forms.Label)sender;
            Helpers.Layout.SetInverseVisibility(expanderLabel);
        }

        private void label_expanderExtensions_Click(object sender, EventArgs e)
        {
            var expanderLabel = (System.Windows.Forms.Label)sender;
            Helpers.Layout.SetInverseVisibility(expanderLabel);
        }
    }
}
