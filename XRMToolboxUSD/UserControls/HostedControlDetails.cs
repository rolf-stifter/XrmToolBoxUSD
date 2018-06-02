using Microsoft.Xrm.Sdk;
using System;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using XRMToolboxUSD.Helpers.Interfaces;
using XRMToolboxUSD.Models;

namespace XRMToolboxUSD.UserControls
{
    public partial class HostedControlDetails : UserControl, DetailsUserControl<USDHostedControl>
    {
        public HostedControlDetails()
        {
            InitializeComponent();
        }

        public void FillDetails(USDHostedControl usdHostedControl)
        {
            if (usdHostedControl == null) return;
            generalHostedControlControl.FillDetails(usdHostedControl);
            hostingHostedControlControl.FillDetails(usdHostedControl);
            automationsHostedControlControl.FillDetails(usdHostedControl);
            extensionsHostedControlControl.FillDetails(usdHostedControl);

            //Set Link in tag
            linkLabel_url.Tag = $"{Helpers.GlobalProperties.WebApplicationUrl}main.aspx?etn=uii_hostedapplication&id={{{usdHostedControl.Id }}}&pagetype=entityrecord";
        }

        private void linkLabel_url_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start((string)((LinkLabel)sender).Tag);
        }
    }
}
