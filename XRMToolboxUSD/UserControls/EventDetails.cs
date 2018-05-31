using System;
using System.Windows.Forms;
using XRMToolboxUSD.Helpers;
using XRMToolboxUSD.Models;

namespace XRMToolboxUSD.UserControls
{
    public partial class EventDetails : UserControl
    {
        public EventDetails()
        {
            InitializeComponent();
        }

        public void FillDetails(USDEvent usdEvent)
        {
            if (usdEvent == null) return;

            textBox_id.Text = usdEvent.Id.ToString();
            textBox_name.Text = usdEvent.Name;
            textBox_hostedApplication.Text = Entities.GetEntityReferenceName(usdEvent.HostedControl);

            //Set Link in tag
            linkLabel_url.Tag = $"{GlobalProperties.WebApplicationUrl}main.aspx?etn=msdyusd_uiievent&id={{{usdEvent.Id }}}&pagetype=entityrecord";
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
    }
}
