using System;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using XRMToolboxUSD.Helpers;
using XRMToolboxUSD.Models;
using XRMToolboxUSD.Repositories;

namespace XRMToolboxUSD.UserControls
{
    public partial class ActionDetails : PluginControlBase
    {
        public ActionDetails()
        {
            InitializeComponent();
        }

        public void FillDetails(USDAction usdAction)
        {
            if (usdAction == null) return;

            textBox_id.Text = usdAction.Id.ToString();
            textBox_name.Text = usdAction.Name;
            textBox_order.Text = usdAction.Order.ToString();
            textBox_hostedControl.Text = Entities.GetEntityReferenceName(usdAction.HostedControl);
            textBox_action.Text = Entities.GetEntityReferenceName(usdAction.Action);
            textBox_data.Text = usdAction.Data;
            textBox_condition.Text = usdAction.Condition;
            textBox_shortcutKey.Text = usdAction.ShortcutKey;

            //Set Link in tag
            linkLabel_url.Tag = $"{GlobalProperties.WebApplicationUrl}main.aspx?etn=msdyusd_agentscriptaction&id={{{usdAction.Id }}}&pagetype=entityrecord";
        }

        private void linkLabel_url_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start((string)((LinkLabel)sender).Tag);
        }

        private void label_expanderGeneral_Click(object sender, EventArgs e)
        {
            var expanderLabel = (Label)sender;
            Helpers.Layout.SetInverseVisibility(expanderLabel);
        }

        private void label_expanderAdvanced_Click(object sender, EventArgs e)
        {
            var expanderLabel = (Label)sender;
            Helpers.Layout.SetInverseVisibility(expanderLabel);
        }
    }
}
