using System.Windows.Forms;
using XRMToolboxUSD.Helpers;
using XRMToolboxUSD.Helpers.Interfaces;
using XRMToolboxUSD.Models.CRM;

namespace XRMToolboxUSD.UserControls.Events
{
    public partial class GeneralEventControl : UserControl, DetailsUserControl<Event>
    {
        public GeneralEventControl()
        {
            InitializeComponent();
        }

        public void FillDetails(Event @event)
        {
            textBox_id.Text = @event.Id.ToString();
            textBox_name.Text = @event.Name;
            textBox_hostedApplication.Text = Entities.GetEntityReferenceName(@event.HostedControl);
        }
    }
}