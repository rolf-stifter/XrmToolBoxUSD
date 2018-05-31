using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using XRMToolboxUSD.Models;
using System.Linq;
using XRMToolboxUSD.Helpers.Enums;

namespace XRMToolboxUSD.Logic
{
    public static class TreeViewGenerator
    {
        public static void GenerateTreeViewFromHostedControls(TreeView tree, List<USDHostedControl> hostedControls, bool showInactive)
        {
            tree.Nodes.Clear();
            foreach (var usdHostedControl in hostedControls)
            {
                if (usdHostedControl.StateCode != StateCode.Inactive || (usdHostedControl.StateCode == StateCode.Inactive && showInactive))
                {
                    var hostedControlNode = GenerateHostedControlNode(usdHostedControl, showInactive);
                    tree.Invoke((MethodInvoker)delegate { tree.Nodes.Add(hostedControlNode); });
                }
            }
        }

        private static TreeNode GenerateHostedControlNode(USDHostedControl usdHostedControl, bool showInactive)
        {
            var hostedControlNode = new TreeNode(usdHostedControl.Name);
            hostedControlNode.Tag = usdHostedControl;
            if (usdHostedControl.StateCode == StateCode.Inactive) hostedControlNode.ForeColor = Color.Gray;

            foreach (var usdEvent in usdHostedControl.Events)
            {
                if (usdEvent.StateCode != StateCode.Inactive || (usdEvent.StateCode == StateCode.Inactive && showInactive))
                {

                    var eventNode = GenerateEventNode(usdEvent, showInactive);
                    hostedControlNode.Nodes.Add(eventNode);
                }
            }
            return hostedControlNode;
        }

        private static TreeNode GenerateEventNode(USDEvent usdEvent, bool showInactive)
        {
            var eventNode = new TreeNode(usdEvent.Name);
            eventNode.Tag = usdEvent;
            if (usdEvent.StateCode == StateCode.Inactive) eventNode.ForeColor = Color.Gray;

            foreach (var usdAction in usdEvent.Actions)
            {
                if (usdAction.StateCode != StateCode.Inactive || (usdAction.StateCode == StateCode.Inactive && showInactive))
                {
                    var actionNode = GenerateActionNode(usdAction, showInactive);
                    eventNode.Nodes.Add(actionNode);
                }
            }
            return eventNode;
        }

        private static TreeNode GenerateActionNode(USDAction usdAction, bool showInactive)
        {
            var actionNode = new TreeNode(usdAction.Name);
            actionNode.Tag = usdAction;
            if (usdAction.StateCode == StateCode.Inactive) actionNode.ForeColor = Color.Gray;
            actionNode.Nodes.AddRange(GenerateSubActionNodes(usdAction, showInactive));
            return actionNode;
        }

        private static TreeNode[] GenerateSubActionNodes(USDAction usdAction, bool showInactive)
        {
            return usdAction.SubActions.Select(sa => {

                if (sa.StateCode != StateCode.Inactive || (sa.StateCode == StateCode.Inactive && showInactive))
                {
                    var subActionNode = new TreeNode(sa.Name);
                    subActionNode.Tag = sa;
                    if (sa.StateCode == StateCode.Inactive) subActionNode.ForeColor = Color.Gray;
                    subActionNode.Nodes.AddRange(GenerateSubActionNodes(sa, showInactive));
                    return subActionNode;
                } return null;
            }).Where(sa=>sa!=null).ToArray();
        }
    }
}
