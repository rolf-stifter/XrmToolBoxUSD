using System;
using System.Collections.Generic;
using System.Windows.Forms;
using XRMToolboxUSD.Models;
using XRMToolboxUSD.Helpers;
using XRMToolboxUSD.Helpers.Interfaces;

namespace XRMToolboxUSD.UserControls.Events
{
    public partial class GeneralEventControl : UserControl, DetailsUserControl<USDEvent>
    {
        public GeneralEventControl()
        {
            InitializeComponent();
        }

        public void FillDetails(USDEvent usdEvent)
        {
            textBox_id.Text = usdEvent.Id.ToString();
            textBox_name.Text = usdEvent.Name;
            textBox_hostedApplication.Text = Entities.GetEntityReferenceName(usdEvent.HostedControl);
        }
    }
}
