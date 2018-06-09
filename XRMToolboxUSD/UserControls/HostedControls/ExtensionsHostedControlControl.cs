using System.Windows.Forms;
using XRMToolboxUSD.Helpers.Interfaces;
using XRMToolboxUSD.Models.CRM;

namespace XRMToolboxUSD.UserControls.HostedControls
{
    public partial class ExtensionsHostedControlControl : UserControl, DetailsUserControl<HostedControl>
    {
        public ExtensionsHostedControlControl()
        {
            InitializeComponent();
        }

        public void FillDetails(HostedControl hostedControl)
        {
            textBox_extensionsXML.Text = hostedControl.ExtensionsXML;
        }
    }
}