using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XRMToolboxUSD.Helpers.Layout
{
    public partial class ExpanderHeader : UserControl
    {
        private string _expanderPanelName;

        [Category("Expander"),Description("This is the title of the expander control.")]
        public string Title
        {
            get { return label_title.Text; }
            set { label_title.Text = value; }
        }


        [Category("Expander"), Description("This is the panel that changes visibly.")]
        public string ExpanderPanelName
        {
            get { return _expanderPanelName; }
            set { _expanderPanelName = value; }
        }


        public ExpanderHeader()
        {
            InitializeComponent();
        }

        private void label_expanderAdvanced_Click(object sender, EventArgs e)
        {
            var expanderControl = ((Label)sender).Parent.Parent.Controls[0];
            expanderControl.Visible = !expanderControl.Visible;
            ((Label)sender).Text = expanderControl.Visible ? "▼" : "▲";
        }
    }
}
