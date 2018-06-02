using System.Windows.Forms;
using XRMToolboxUSD.Models;
using XRMToolboxUSD.Helpers.Interfaces;

namespace XRMToolboxUSD.UserControls.HostedControls
{
    public partial class AutomationsHostedControlControl : UserControl, DetailsUserControl<USDHostedControl>
    {
        public AutomationsHostedControlControl()
        {
            InitializeComponent();
        }

        public void FillDetails(USDHostedControl usdHostedControl)
        {
            textBox_automationXML.Text = usdHostedControl.AutomationXML;
        }
    }
}
