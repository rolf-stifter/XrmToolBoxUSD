using Microsoft.Xrm.Sdk;
using System.Collections.Generic;

namespace XRMToolboxUSD.Models.CRM

{
    public class Action : USDEntity
    {
        #region General
        #region General
        public int Order { get; set; }
        #endregion

        #region Action
        public EntityReference HostedControl { get; set; }
        public EntityReference UIIAction { get; set; }
        public string Data { get; set; }
        #endregion
        #endregion

        #region Advanced
        #region Advanced
        public string Condition { get; set; }
        public string ShortcutKey { get; set; }
        #endregion
        #endregion

        public List<Action> SubActions { get; set; }
    }
}