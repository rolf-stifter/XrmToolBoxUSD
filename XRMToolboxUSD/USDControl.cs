using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using XRMToolboxUSD.Models;
using XRMToolboxUSD.Repositories;
using System.Web.Services.Description;
using XRMToolboxUSD.Logic;
using XRMToolboxUSD.UserControls;

namespace XRMToolboxUSD
{
    public partial class USDControl : PluginControlBase
    {
        private USDConfigurationData usdConfigData;
        private HostedControlDetails hostedCotrolDetailsControl;
        private EventDetails eventDetailsControl;
        private ActionDetails actionDetailsControl;


        public USDControl()
        {
            InitializeComponent();
            hostedCotrolDetailsControl = new HostedControlDetails() { Dock = DockStyle.Fill };
            eventDetailsControl = new EventDetails() { Dock = DockStyle.Fill };
            actionDetailsControl = new ActionDetails() { Dock = DockStyle.Fill };
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ExecuteMethod(RefreshUSDConfigurationDataTree);
        }

        private void RefreshUSDConfigurationDataTree()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Retrieving USD Configuration...",
                Work = (w, e) =>
                {
                    Helpers.GlobalProperties.WebApplicationUrl = ConnectionDetail.WebApplicationUrl;

                    usdConfigData = new USDConfigurationData();

                    w.ReportProgress(0, "Retrieving Hosted Controls");
                    usdConfigData.HostedControls = HostedControlRepository.GetHostedControls(Service);

                    w.ReportProgress(0, "Retrieving Events");
                    usdConfigData.Events = EventRepository.GetEvents(Service);

                    w.ReportProgress(0, "Retrieving Actions");
                    usdConfigData.Actions = ActionRepository.GetActions(Service);

                    w.ReportProgress(0, "Retrieving Event-Action Connections");
                    usdConfigData.EventActionConnections = EventActionConnectionRepository.GetEventActionConnections(Service);

                    w.ReportProgress(0, "Retrieving Action-SubAction Connections");
                    usdConfigData.ActionSubActionConnections = ActionSubActionRepository.GetActionSubActionConnections(Service);

                    w.ReportProgress(0, "Drawing Tree");
                    DrawTreeView(usdConfigData);

                    tabControl1.Invoke((MethodInvoker)delegate { tabControl1.Enabled = true; });

                    e.Result = "Done";
                },
                ProgressChanged = e =>
                {
                    SetWorkingMessage(e.UserState.ToString());
                },
                PostWorkCallBack = e =>
                {
                    //MessageBox.Show($"You are { e.Result}");
                },
                AsyncArgument = null,
                IsCancelable = true,
                MessageWidth = 340,
                MessageHeight = 150
            });
        }

        public void DrawTreeView(USDConfigurationData usdConfigData)
        {
            this.usdConfigData = usdConfigData;
            var usdTree = USDTree.GenerateUSDTree(usdConfigData);
            TreeViewGenerator.GenerateTreeViewFromHostedControls(treeView1, usdTree, checkBox1.Checked);
        }

        private void ShowNodePath(TreeNode node)
        {
            string path = node.Text;
            while (node.Parent != null)
            {
                node = node.Parent;
                path = $"{node.Text} > " + path;
            }
            MessageBox.Show(path);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            DrawTreeView(usdConfigData);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            panel3.Controls.Clear();

            var usdElement = ((TreeView)sender).SelectedNode.Tag;

            if (usdElement is USDHostedControl)
            {
                hostedCotrolDetailsControl.Tag = (USDHostedControl)usdElement;
                panel3.Controls.Add(hostedCotrolDetailsControl);
                hostedCotrolDetailsControl.FillDetails((USDHostedControl)usdElement);
            }
            else if (usdElement is USDEvent)
            {
                panel3.Controls.Add(eventDetailsControl);
                eventDetailsControl.FillDetails((USDEvent)usdElement);
            }
            else if (usdElement is USDAction)
            {
                panel3.Controls.Add(actionDetailsControl);
                actionDetailsControl.FillDetails((USDAction)usdElement);
            }
        }

        private void toolStripButton_about_Click(object sender, EventArgs e)
        {
            new Forms.About().ShowDialog();
        }
    }
}
