using System;

namespace XRMToolboxUSD.Models.CRM
{
    public class ActionSubActionConnection
    {
        public Guid Id { get; set; }
        public Guid ActionId { get; set; }
        public Guid SubActionId { get; set; }
    }
}