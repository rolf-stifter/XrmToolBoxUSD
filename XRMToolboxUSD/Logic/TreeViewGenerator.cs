using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using XRMToolboxUSD.Helpers.Enums;
using XRMToolboxUSD.Models.CRM;

namespace XRMToolboxUSD.Logic
{
    public static class TreeViewGenerator
    {
        public static void GenerateTreeViewFromHostedControls(TreeView tree, List<HostedControl> hostedControls, bool showInactive)
        {
            tree.Nodes.Clear();
            foreach (var hostedControl in hostedControls)
            {
                if (hostedControl.StateCode != StateCode.Inactive || (hostedControl.StateCode == StateCode.Inactive && showInactive))
                {
                    var hostedControlNode = GenerateHostedControlNode(hostedControl, showInactive);
                    tree.Invoke((MethodInvoker)delegate { tree.Nodes.Add(hostedControlNode); });
                }
            }
        }

        private static TreeNode GenerateHostedControlNode(HostedControl hostedControl, bool showInactive)
        {
            var hostedControlNode = new TreeNode(hostedControl.Name);
            hostedControlNode.Tag = hostedControl;
            if (hostedControl.StateCode == StateCode.Inactive) hostedControlNode.ForeColor = Color.Gray;

            foreach (var @event in hostedControl.Events)
            {
                if (@event.StateCode != StateCode.Inactive || (@event.StateCode == StateCode.Inactive && showInactive))
                {

                    var eventNode = GenerateEventNode(@event, showInactive);
                    hostedControlNode.Nodes.Add(eventNode);
                }
            }
            return hostedControlNode;
        }

        private static TreeNode GenerateEventNode(Event @event, bool showInactive)
        {
            var eventNode = new TreeNode(@event.Name);
            eventNode.Tag = @event;
            if (@event.StateCode == StateCode.Inactive) eventNode.ForeColor = Color.Gray;

            foreach (var action in @event.Actions)
            {
                if (action.StateCode != StateCode.Inactive || (action.StateCode == StateCode.Inactive && showInactive))
                {
                    var actionNode = GenerateActionNode(action, showInactive);
                    eventNode.Nodes.Add(actionNode);
                }
            }
            return eventNode;
        }

        private static TreeNode GenerateActionNode(Action action, bool showInactive)
        {
            var actionNode = new TreeNode(action.Name);
            actionNode.Tag = action;
            if (action.StateCode == StateCode.Inactive) actionNode.ForeColor = Color.Gray;
            actionNode.Nodes.AddRange(GenerateSubActionNodes(action, showInactive));
            return actionNode;
        }

        private static TreeNode[] GenerateSubActionNodes(Action action, bool showInactive)
        {
            return action.SubActions.Select(sa => {

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
