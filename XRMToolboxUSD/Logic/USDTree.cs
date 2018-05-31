using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XRMToolboxUSD.Models;

namespace XRMToolboxUSD.Logic
{
    public static class USDTree
    {
        public static List<USDHostedControl> GenerateUSDTree(USDConfigurationData usdConfigData)
        {
            return usdConfigData.HostedControls.Select(
                h =>
                {
                    h.Events = usdConfigData.Events.Where(e => e.HostedControl != null && e.HostedControl.Id == h.Id).OrderBy(e => e.Name).Select(
                        e =>
                        {
                            e.Actions = usdConfigData.EventActionConnections.Where(c => c.EventId == e.Id).Select(c => usdConfigData.Actions.FirstOrDefault(a => a.Id == c.ActionId)).OrderBy(a => a.Order).ThenBy(a => a.Name).ToList();
                            e.Actions.ForEach(a => a.SubActions = GetSubActionsByActionId(usdConfigData, a.Id));
                            return e;
                        }).ToList();
                    return h;
                }).ToList();
        }

        private static List<USDAction> GetSubActionsByActionId(USDConfigurationData usdConfigData, Guid actionId)
        {
            return usdConfigData.ActionSubActionConnections.Where(c => c.ActionId == actionId).Select(c =>
            {
                var subaction = usdConfigData.Actions.FirstOrDefault(sa => sa.Id == c.SubActionId);
                subaction.SubActions = GetSubActionsByActionId(usdConfigData, subaction.Id);
                return subaction;
            }).OrderBy(a => a.Order).ThenBy(a => a.Name).ToList();
        }
    }
}
