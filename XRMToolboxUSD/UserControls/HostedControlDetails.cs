using System.Windows.Forms;
using XRMToolboxUSD.Helpers.Interfaces;
using XRMToolboxUSD.Models.CRM;

namespace XRMToolboxUSD.UserControls
{
    public partial class HostedControlDetails : UserControl, DetailsUserControl<HostedControl>
    {
        public HostedControlDetails()
        {
            InitializeComponent();
        }

        public void FillDetails(HostedControl hostedControl)
        {
            if (hostedControl == null) return;
            generalHostedControlControl.FillDetails(hostedControl);
            hostingHostedControlControl.FillDetails(hostedControl);
            automationsHostedControlControl.FillDetails(hostedControl);
            extensionsHostedControlControl.FillDetails(hostedControl);

            //Set Link in tag
            linkLabel_url.Tag = $"{Helpers.GlobalProperties.WebApplicationUrl}main.aspx?etn=uii_hostedapplication&id={{{hostedControl.Id }}}&pagetype=entityrecord";
        }

        private void linkLabel_url_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start((string)((LinkLabel)sender).Tag);
        }
    }
}