using System.Windows.Forms;
using XRMToolboxUSD.Helpers.Interfaces;
using XRMToolboxUSD.Models.CRM;

namespace XRMToolboxUSD.UserControls.HostedControls
{
    public partial class AutomationsHostedControlControl : UserControl, DetailsUserControl<HostedControl>
    {
        public AutomationsHostedControlControl()
        {
            InitializeComponent();
        }

        public void FillDetails(HostedControl hostedControl)
        {
            textBox_automationXML.Text = hostedControl.AutomationXML;
        }
    }
}