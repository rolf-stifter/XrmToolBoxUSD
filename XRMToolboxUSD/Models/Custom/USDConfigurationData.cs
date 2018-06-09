using System.Collections.Generic;
using XRMToolboxUSD.Models.CRM;

namespace XRMToolboxUSD.Models.Custom
{
    public class USDConfigurationData
    {
        public List<HostedControl> HostedControls { get; set; }
        public List<Event> Events { get; set; }
        public List<Action> Actions { get; set; }
        public List<EventActionConnection> EventActionConnections { get; set; }
        public List<ActionSubActionConnection> ActionSubActionConnections { get; set; }
        public USDConfigurationData()
        {
            HostedControls = new List<HostedControl>();
            Events = new List<Event>();
            Actions = new List<Action>();
            EventActionConnections = new List<EventActionConnection>();
            ActionSubActionConnections = new List<ActionSubActionConnection>();
        }
    }
}
