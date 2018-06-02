using System.Windows.Forms;
using XRMToolboxUSD.Models;
using XRMToolboxUSD.Helpers.Interfaces;

namespace XRMToolboxUSD.UserControls.HostedControls
{
    public partial class ExtensionsHostedControlControl : UserControl, DetailsUserControl<USDHostedControl>
    {
        public ExtensionsHostedControlControl()
        {
            InitializeComponent();
        }

        public void FillDetails(USDHostedControl usdHostedControl)
        {
            textBox_extensionsXML.Text = usdHostedControl.ExtensionsXML;
        }
    }
}
