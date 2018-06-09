using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using XRMToolboxUSD.Models.CRM;

namespace XRMToolboxUSD.Repositories
{
    public static class EventActionConnectionRepository
    {
        public static List<EventActionConnection> GetEventActionConnections(IOrganizationService service)
        {
            QueryExpression eventsQuery = new QueryExpression
            {
                EntityName = "msdyusd_uiievent_agentscriptaction",
                ColumnSet = new ColumnSet("msdyusd_uiievent_agentscriptactionid", "msdyusd_uiieventid", "msdyusd_agentscriptactionid")
            };

            return service.RetrieveMultiple(eventsQuery).Entities.Select(x => ConvertEntityToEventActionConnection(x)).ToList();
        }

        private static EventActionConnection ConvertEntityToEventActionConnection(Entity entity)
        {
            return new EventActionConnection
            {
                Id = entity.GetAttributeValue<Guid>("msdyusd_uiieventid"),
                EventId = entity.GetAttributeValue<Guid>("msdyusd_uiieventid"),
                ActionId = entity.GetAttributeValue<Guid>("msdyusd_agentscriptactionid")
            };
        }
    }
}