using System;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using XRMToolboxUSD.Helpers;
using XRMToolboxUSD.Helpers.Interfaces;
using XRMToolboxUSD.Models;

namespace XRMToolboxUSD.UserControls
{
    public partial class ActionDetails : UserControl, DetailsUserControl<USDAction>
    {
        public ActionDetails()
        {
            InitializeComponent();
        }

        public void FillDetails(USDAction usdAction)
        {
            if (usdAction == null) return;
            generalActionControl.FillDetails(usdAction);
            advancedActionControl.FillDetails(usdAction);

            //Set Link in tag
            linkLabel_url.Tag = $"{GlobalProperties.WebApplicationUrl}main.aspx?etn=msdyusd_agentscriptaction&id={{{usdAction.Id }}}&pagetype=entityrecord";
        }

        private void linkLabel_url_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start((string)((LinkLabel)sender).Tag);
        }
    }
}
