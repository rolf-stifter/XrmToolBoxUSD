using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using XRMToolboxUSD.Helpers.Enums;

namespace XRMToolboxUSD.Models

{
    public class USDAction : USDEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public EntityReference HostedControl { get; set; }
        public EntityReference Action { get; set; }
        public string Data { get; set; }
        public string Condition { get; set; }
        public string ShortcutKey { get; set; }
        public StateCode StateCode { get; set; }
        public List<USDAction> SubActions { get; set; }
    }
}
