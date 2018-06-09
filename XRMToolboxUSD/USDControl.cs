using System;
using System.Drawing;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using XRMToolboxUSD.Repositories;
using XRMToolboxUSD.Logic;
using XRMToolboxUSD.UserControls;
using XRMToolboxUSD.Models.Custom;
using XRMToolboxUSD.Models.CRM;

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

        private void toolStripButton_about_Click(object sender, EventArgs e)
        {
            new Forms.AboutBox().ShowDialog();
        }

        private void toolStripMenuItem_copyID_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Tag is USDEntity)
                Clipboard.SetText((treeView1.SelectedNode.Tag as USDEntity).Id.ToString());
        }

        private void toolStripMenuItem_copyName_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Tag is USDEntity)
                Clipboard.SetText((treeView1.SelectedNode.Tag as USDEntity).Name);
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (treeView1.SelectedNode == null) return;

            if (e.Button == MouseButtons.Right && sender is Control)
            {
                ShowContextMenu(e.Location);
            }
        }

        private void ShowContextMenu(Point location)
        {
            // Get the node that the user has clicked.
            TreeNode node = treeView1.GetNodeAt(location);
            if (node == null) return;

            treeView1.SelectedNode = node;

            contextMenuStrip_treeElements.Show(treeView1, location.X, location.Y);
        }

        private void ShowDetails(USDEntity usdEntity)
        {
            panel3.Controls.Clear();

            if (usdEntity is HostedControl)
            {
                hostedCotrolDetailsControl.Tag = (HostedControl)usdEntity;
                panel3.Controls.Add(hostedCotrolDetailsControl);
                hostedCotrolDetailsControl.FillDetails((HostedControl)usdEntity);
            }
            else if (usdEntity is Event)
            {
                panel3.Controls.Add(eventDetailsControl);
                eventDetailsControl.FillDetails((Event)usdEntity);
            }
            else if (usdEntity is Models.CRM.Action)
            {
                panel3.Controls.Add(actionDetailsControl);
                actionDetailsControl.FillDetails((Models.CRM.Action)usdEntity);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ShowDetails((USDEntity)treeView1.SelectedNode.Tag);
        }
    }
}