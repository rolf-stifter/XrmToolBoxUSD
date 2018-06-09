using System.Windows.Forms;
using XRMToolboxUSD.Helpers.Interfaces;
using XRMToolboxUSD.Models.CRM;

namespace XRMToolboxUSD.UserControls.HostedControls
{
    public partial class GeneralHostedControlControl : UserControl, DetailsUserControl<HostedControl>
    {
        public GeneralHostedControlControl()
        {
            InitializeComponent();
        }

        public void FillDetails(HostedControl hostedControl)
        {
            textBox_name.Text = hostedControl.Name;
            textBox_id.Text = hostedControl.Id.ToString();
            textBox_sortOrder.Text = hostedControl.SortOrder.ToString();
            textBox_displayName.Text = hostedControl.DisplayName;
            comboBox_componentType.SelectedItem = hostedControl.ComponentType;
            textBox_savedURL.Text = hostedControl.SavedURL;
            checkBox_preFetchData.Checked = hostedControl.PreFetchData;
            textBox_dashboardName.Text = hostedControl.DashboardName;
            checkBox_allowMultiplePages.Checked = hostedControl.AllowMultiplePages;
            textBox_hostingType.Text = hostedControl.HostingType.ToString();
            textBox_maximumBrowsers.Text = hostedControl.MaximumBrowsers.ToString();
            checkBox_scanForDataParameters.Checked = hostedControl.ScanForDataParameters;
            textBox_panelType.Text = hostedControl.PanelType.ToString();
            textBox_XAML.Text = hostedControl.Xaml;
            textBox_hostedAppType.Text = hostedControl.HostedApplicationType.ToString();
            checkBox_appIsGlobal.Checked = hostedControl.ApplicationIsGlobal;
            checkBox_dependentOnWorkflow.Checked = hostedControl.DependentOnWorkflow;
            textBox_displayGroup.Text = hostedControl.DisplayGroup;
            textBox_minimumX.Text = hostedControl.MinimumX.ToString();
            textBox_minimumY.Text = hostedControl.MinimumY.ToString();
            textBox_optimalX.Text = hostedControl.OptimalX.ToString();
            textBox_optimalY.Text = hostedControl.OptimalY.ToString();
            textBox_adapter.Text = hostedControl.Adapter.ToString();
            textBox_uri.Text = hostedControl.URI;
            textBox_type.Text = hostedControl.Type;
            checkBox_applicationDynamic.Checked = hostedControl.ApplicationIsDynamic;
            checkBox_userCanClose.Checked = hostedControl.UserCanClose;
            checkBox_showInToolbarDropdown.Checked = hostedControl.ShowInToolbarDropdown;
        }
    }
}