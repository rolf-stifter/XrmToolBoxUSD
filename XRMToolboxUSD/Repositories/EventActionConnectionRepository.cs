using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XRMToolboxUSD.Models;

namespace XRMToolboxUSD.Repositories
{
    public static class EventActionConnectionRepository
    {
        public static List<USDEventActionConnection> GetEventActionConnections(IOrganizationService service)
        {
            QueryExpression eventsQuery = new QueryExpression
            {
                EntityName = "msdyusd_uiievent_agentscriptaction",
                ColumnSet = new ColumnSet("msdyusd_uiievent_agentscriptactionid", "msdyusd_uiieventid", "msdyusd_agentscriptactionid")
            };

            return service.RetrieveMultiple(eventsQuery).Entities.Select(x => ConvertEntityToEventActionConnection(x)).ToList();
        }

        private static USDEventActionConnection ConvertEntityToEventActionConnection(Entity entity)
        {
            return new USDEventActionConnection
            {
                Id = entity.GetAttributeValue<Guid>("msdyusd_uiieventid"),
                EventId = entity.GetAttributeValue<Guid>("msdyusd_uiieventid"),
                ActionId = entity.GetAttributeValue<Guid>("msdyusd_agentscriptactionid")
            };
        }
    }
}
