using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using XRMToolboxUSD.Models.CRM;

namespace XRMToolboxUSD.Repositories
{
    public static class ActionSubActionRepository
    {
        public static List<ActionSubActionConnection> GetActionSubActionConnections(IOrganizationService service)
        {
            QueryExpression query = new QueryExpression
            {
                EntityName = "msdyusd_subactioncalls",
                ColumnSet = new ColumnSet("msdyusd_subactioncallsid", "msdyusd_agentscriptactionidone", "msdyusd_agentscriptactionidtwo")
            };

            return service.RetrieveMultiple(query).Entities.Select(x => ConvertEntityToActionSubActionConnection(x)).ToList();
        }

        private static ActionSubActionConnection ConvertEntityToActionSubActionConnection(Entity entity)
        {
            return new ActionSubActionConnection
            {
                Id = entity.GetAttributeValue<Guid>("msdyusd_subactioncallsid"),
                ActionId = entity.GetAttributeValue<Guid>("msdyusd_agentscriptactionidtwo"),
                SubActionId = entity.GetAttributeValue<Guid>("msdyusd_agentscriptactionidone")
            };
        }
    }
}