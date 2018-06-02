using System;
using System.Windows.Forms;
using XRMToolboxUSD.Helpers;
using XRMToolboxUSD.Models;
using XRMToolboxUSD.Helpers.Interfaces;

namespace XRMToolboxUSD.UserControls.Actions
{
    public partial class GeneralActionControl : UserControl, DetailsUserControl<USDAction>
    {
        public GeneralActionControl()
        {
            InitializeComponent();
        }

        public void FillDetails(USDAction usdAction)
        {
            textBox_id.Text = usdAction.Id.ToString();
            textBox_name.Text = usdAction.Name;
            textBox_order.Text = usdAction.Order.ToString();
            textBox_hostedControl.Text = Entities.GetEntityReferenceName(usdAction.HostedControl);
            textBox_action.Text = Entities.GetEntityReferenceName(usdAction.Action);
            textBox_data.Text = usdAction.Data;
        }
    }
}
