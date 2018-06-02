using System.Windows.Forms;
using XRMToolboxUSD.Models;
using XRMToolboxUSD.Helpers.Interfaces;

namespace XRMToolboxUSD.UserControls.HostedControls
{
    public partial class HostingHostedControlControl : UserControl, DetailsUserControl<USDHostedControl>
    {
        public HostingHostedControlControl()
        {
            InitializeComponent();
        }

        public void FillDetails(USDHostedControl usdHostedControl)
        {
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
        }
    }
}
