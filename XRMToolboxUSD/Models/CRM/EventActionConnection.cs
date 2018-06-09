using System;

namespace XRMToolboxUSD.Models.CRM
{
    public class EventActionConnection
    {
        public Guid Id { get; set; }
        public Guid EventId { get; set; }
        public Guid ActionId { get; set; }
    }
}