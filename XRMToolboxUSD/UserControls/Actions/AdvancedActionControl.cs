using System;
using System.Windows.Forms;
using XRMToolboxUSD.Helpers.Interfaces;
using XRMToolboxUSD.Models.CRM;

namespace XRMToolboxUSD.UserControls.Actions
{
    public partial class AdvancedActionControl : UserControl, DetailsUserControl<Models.CRM.Action>
    {
        public AdvancedActionControl()
        {
            InitializeComponent();
        }

        public void FillDetails(Models.CRM.Action action)
        {
            textBox_condition.Text = action.Condition;
            textBox_shortcutKey.Text = action.ShortcutKey;
        }
    }
}