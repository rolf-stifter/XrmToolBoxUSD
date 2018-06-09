using System.Windows.Forms;
using XRMToolboxUSD.Helpers.Interfaces;
using XRMToolboxUSD.Models.CRM;

namespace XRMToolboxUSD.UserControls.HostedControls
{
    public partial class HostingHostedControlControl : UserControl, DetailsUserControl<HostedControl>
    {
        public HostingHostedControlControl()
        {
            InitializeComponent();
        }

        public void FillDetails(HostedControl hostedControl)
        {
            textBox_externalAppURI.Text = hostedControl.ExternalAppURI;
            textBox_arguments.Text = hostedControl.Arguments;
            textBox_workingDirectory.Text = hostedControl.WorkingDirectory;
            checkBox_manageHosting.Checked = hostedControl.ManageHosting;
            textBox_applicationHostingMode.Text = hostedControl.ApplicationHostingMode.ToString();
            checkBox_attachInputThread.Checked = hostedControl.AttachInputThread;
            checkBox_showMenu.Checked = hostedControl.ShowMenu;
            checkBox_noMessagePump.Checked = hostedControl.NoMessagePump;
            textBox_mainWindowAcquisitionTimeout.Text = hostedControl.MainWindowAcquisitionTimeout.ToString();
            textBox_topLevelWindowMode.Text = hostedControl.TopLevelWindowMode.ToString();
            textBox_caption.Text = hostedControl.Caption;
            textBox_findWindowClass.Text = hostedControl.FindWindowClass;
            checkBox_limitToProcess.Checked = hostedControl.LimitToProcess;
            textBox_url.Text = hostedControl.URL;
            checkBox_useToolbar.Checked = hostedControl.UseToolbar;
            checkBox_useNewBrowserProcess.Checked = hostedControl.UseNewBrowserProcess;
            checkBox_managePopups.Checked = hostedControl.ManagePopups;
            textBox_assemblyURI.Text = hostedControl.AssemblyURI;
            textBox_assemblyType.Text = hostedControl.AssemblyType;
            checkBox_retainFrameAndCaption.Checked = hostedControl.RetainFrameAndCaption;
            checkBox_retainOnTaskbar.Checked = hostedControl.RetainOnTaskbar;
            checkBox_retainSystemMenu.Checked = hostedControl.RetainSystemMenu;
            checkBox_restoreIfMinimized.Checked = hostedControl.RestoreIfMinimized;
            checkBox_removeSizingControls.Checked = hostedControl.RemoveSizingControls;
            textBox_icaFileName.Text = hostedControl.ICAFileName;
            textBox_processAcquisitionAttempts.Text = hostedControl.ProcessAcquisitionAttempts.ToString();
            textBox_processAcquisitionDelay.Text = hostedControl.ProcessAcquisitionDelay.ToString();
            textBox_processAcquisitionFilename.Text = hostedControl.ProcessAcquisitionFilename;
        }
    }
}