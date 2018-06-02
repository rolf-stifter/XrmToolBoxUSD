using System.Windows.Forms;
using XRMToolboxUSD.Models;
using XRMToolboxUSD.Helpers.Interfaces;

namespace XRMToolboxUSD.UserControls.HostedControls
{
    public partial class GeneralHostedControlControl : UserControl, DetailsUserControl<USDHostedControl>
    {
        public GeneralHostedControlControl()
        {
            InitializeComponent();
        }

        public void FillDetails(USDHostedControl usdHostedControl)
        {
            textBox_name.Text = usdHostedControl.Name;
            textBox_id.Text = usdHostedControl.Id.ToString();
            textBox_sortOrder.Text = usdHostedControl.SortOrder.ToString();
            textBox_displayName.Text = usdHostedControl.DisplayName;
            comboBox_componentType.SelectedItem = usdHostedControl.ComponentType;
            textBox_savedURL.Text = usdHostedControl.SavedURL;
            checkBox_preFetchData.Checked = usdHostedControl.PreFetchData;
            textBox_dashboardName.Text = usdHostedControl.DashboardName;
            checkBox_allowMultiplePages.Checked = usdHostedControl.AllowMultiplePages;
            textBox_hostingType.Text = usdHostedControl.HostingType.ToString();
            textBox_maximumBrowsers.Text = usdHostedControl.MaximumBrowsers.ToString();
            checkBox_scanForDataParameters.Checked = usdHostedControl.ScanForDataParameters;
            textBox_panelType.Text = usdHostedControl.PanelType.ToString();
            textBox_XAML.Text = usdHostedControl.Xaml;
            textBox_hostedAppType.Text = usdHostedControl.HostedApplicationType.ToString();
            checkBox_appIsGlobal.Checked = usdHostedControl.ApplicationIsGlobal;
            checkBox_dependentOnWorkflow.Checked = usdHostedControl.DependentOnWorkflow;
            textBox_displayGroup.Text = usdHostedControl.DisplayGroup;
            textBox_minimumX.Text = usdHostedControl.MinimumX.ToString();
            textBox_minimumY.Text = usdHostedControl.MinimumY.ToString();
            textBox_optimalX.Text = usdHostedControl.OptimalX.ToString();
            textBox_optimalY.Text = usdHostedControl.OptimalY.ToString();
            textBox_adapter.Text = usdHostedControl.Adapter.ToString();
            textBox_uri.Text = usdHostedControl.URI;
            textBox_type.Text = usdHostedControl.Type;
            checkBox_applicationDynamic.Checked = usdHostedControl.ApplicationIsDynamic;
            checkBox_userCanClose.Checked = usdHostedControl.UserCanClose;
            checkBox_showInToolbarDropdown.Checked = usdHostedControl.ShowInToolbarDropdown;
        }
    }
}
