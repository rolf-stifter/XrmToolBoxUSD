using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using XRMToolboxUSD.Helpers.Enums;

namespace XRMToolboxUSD.Models
{
    public class USDEvent : USDEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public EntityReference HostedControl { get; set; }
        public StateCode StateCode { get; set; }
        public List<USDAction> Actions { get; set; }
    }
}
