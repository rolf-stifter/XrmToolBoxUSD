using System;
using System.Windows.Forms;
using XRMToolboxUSD.Helpers;
using XRMToolboxUSD.Helpers.Interfaces;

namespace XRMToolboxUSD.UserControls
{
    public partial class ActionDetails : UserControl, DetailsUserControl<Models.CRM.Action>
    {
        public ActionDetails()
        {
            InitializeComponent();
        }

        public void FillDetails(Models.CRM.Action action)
        {
            if (action == null) return;
            generalActionControl.FillDetails(action);
            advancedActionControl.FillDetails(action);

            //Set Link in tag
            linkLabel_url.Tag = $"{GlobalProperties.WebApplicationUrl}main.aspx?etn=msdyusd_agentscriptaction&id={{{action.Id }}}&pagetype=entityrecord";
        }

        private void linkLabel_url_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start((string)((LinkLabel)sender).Tag);
        }
    }
}