using System;
using System.Windows.Forms;
using XRMToolboxUSD.Helpers;
using XRMToolboxUSD.Models.CRM;
using XRMToolboxUSD.Helpers.Interfaces;

namespace XRMToolboxUSD.UserControls.Actions
{
    public partial class GeneralActionControl : UserControl, DetailsUserControl<Models.CRM.Action>
    {
        public GeneralActionControl()
        {
            InitializeComponent();
        }

        public void FillDetails(Models.CRM.Action action)
        {
            textBox_id.Text = action.Id.ToString();
            textBox_name.Text = action.Name;
            textBox_order.Text = action.Order.ToString();
            textBox_hostedControl.Text = Entities.GetEntityReferenceName(action.HostedControl);
            textBox_action.Text = Entities.GetEntityReferenceName(action.UIIAction);
            textBox_data.Text = action.Data;
        }
    }
}