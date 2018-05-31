using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XRMToolboxUSD.Models
{
    public class USDConfigurationData
    {
        public List<USDHostedControl> HostedControls { get; set; }
        public List<USDEvent> Events { get; set; }
        public List<USDAction> Actions { get; set; }
        public List<USDEventActionConnection> EventActionConnections { get; set; }
        public List<USDActionSubActionConnection> ActionSubActionConnections { get; set; }
        public USDConfigurationData()
        {
            HostedControls = new List<USDHostedControl>();
            Events = new List<USDEvent>();
            Actions = new List<USDAction>();
            EventActionConnections = new List<USDEventActionConnection>();
            ActionSubActionConnections = new List<USDActionSubActionConnection>();
        }
    }
}
