using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using XRMToolboxUSD.Helpers;
using XRMToolboxUSD.Helpers.Enums;
using XRMToolboxUSD.Models.CRM;

namespace XRMToolboxUSD.Repositories
{
    public static class EventRepository
    {
        public static List<Event> GetEvents(IOrganizationService service)
        {
            QueryExpression eventsQuery = new QueryExpression
            {
                EntityName = "msdyusd_uiievent",
                ColumnSet = new ColumnSet(true),
                Criteria = new FilterExpression
                {

                },
                Orders =
                {
                    new OrderExpression
                    {
                        AttributeName = "msdyusd_name",
                        OrderType = OrderType.Ascending
                    }
                }
            };

            return service.RetrieveMultiple(eventsQuery).Entities.Select(x => ConvertEntityToEvent(x)).ToList();
        }

        private static Event ConvertEntityToEvent(Entity entity)
        {
            return new Event
            {
                Id = entity.GetAttributeValue<Guid>("msdyusd_uiieventid"),
                Name = entity.GetAttributeValue<string>("msdyusd_name"),
                HostedControl = entity.GetAttributeValue<EntityReference>("msdyusd_hostedapplicationid"),
                StateCode = (StateCode)entity.GetOptionSetValue("statecode"),
            };
        }
    }
}