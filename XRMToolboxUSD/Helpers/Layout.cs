using System.Windows.Forms;

namespace XRMToolboxUSD.Helpers
{
    public static class Layout
    {
        public static void SetInverseVisibility(Control expanderControl)
        {
            expanderControl.Parent.Parent.Controls[0].Visible = !expanderControl.Parent.Parent.Controls[0].Visible;
            ((Label)expanderControl).Text = expanderControl.Parent.Parent.Controls[0].Visible ? "▼" : "▲";
        }
    }
}