using System;
using System.Windows.Forms;
using XRMToolboxUSD.Models;
using XRMToolboxUSD.Helpers.Interfaces;

namespace XRMToolboxUSD.UserControls.Actions
{
    public partial class AdvancedActionControl : UserControl, DetailsUserControl<USDAction>
    {
        public AdvancedActionControl()
        {
            InitializeComponent();
        }

        public void FillDetails(USDAction usdAction)
        {
            textBox_condition.Text = usdAction.Condition;
            textBox_shortcutKey.Text = usdAction.ShortcutKey;
        }
    }
}
