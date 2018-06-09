using System;
using System.Windows.Forms;
using XRMToolboxUSD.Helpers;
using XRMToolboxUSD.Helpers.Interfaces;
using XRMToolboxUSD.Models.CRM;

namespace XRMToolboxUSD.UserControls
{
    public partial class EventDetails : UserControl,DetailsUserControl<Event>
    {
        public EventDetails()
        {
            InitializeComponent();
        }

        public void FillDetails(Event @event)
        {
            if (@event == null) return;
            generalEventControl.FillDetails(@event);

            //Set Link in tag
            linkLabel_url.Tag = $"{GlobalProperties.WebApplicationUrl}main.aspx?etn=msdyusd_uiievent&id={{{@event.Id }}}&pagetype=entityrecord";
        }

        private void linkLabel_url_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start((string)((LinkLabel)sender).Tag);
        }

        private void label_expanderGeneral_Click(object sender, EventArgs e)
        {
            //var expanderLabel = (Label)sender;
            //Helpers.Layout.SetInverseVisibility(expanderLabel);
        }
    }
}