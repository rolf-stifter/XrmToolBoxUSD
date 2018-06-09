using Microsoft.Xrm.Sdk;
using System.Collections.Generic;

namespace XRMToolboxUSD.Models.CRM
{
    public class Event : USDEntity
    {
        #region General
        #region General
        public EntityReference HostedControl { get; set; }
        #endregion
        #endregion
        public List<Action> Actions { get; set; }
    }
}