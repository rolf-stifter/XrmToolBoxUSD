using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using XRMToolboxUSD.Helpers;
using XRMToolboxUSD.Helpers.Enums;
using XRMToolboxUSD.Models;

namespace XRMToolboxUSD.Repositories
{
    public static class ActionRepository
    {
        public static List<USDAction> GetActions(IOrganizationService service)
        {
            QueryExpression actionsQuery = new QueryExpression
            {
                EntityName = "msdyusd_agentscriptaction",
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

            return service.RetrieveMultiple(actionsQuery).Entities.Select(x => ConvertEntityToAction(x)).ToList();
        }

        public static void UpdateAction(IOrganizationService service, USDAction usdAction)
        {
            var entity = ConvertActionToEntity(usdAction);
            service.Update(entity);
        }


        private static USDAction ConvertEntityToAction(Entity entity)
        {
            return new USDAction
            {
                Id = entity.GetAttributeValue<Guid>("msdyusd_agentscriptactionid"),
                Name = entity.GetAttributeValue<string>("msdyusd_name"),
                Order = entity.GetAttributeValue<int>("msdyusd_order"),
                HostedControl = entity.GetAttributeValue<EntityReference>("msdyusd_application"),
                Action = entity.GetAttributeValue<EntityReference>("msdyusd_action"),
                Data = entity.GetAttributeValue<string>("msdyusd_actiondata"),
                Condition = entity.GetAttributeValue<string>("msdyusd_condition"),
                ShortcutKey = entity.GetAttributeValue<string>("msdyusd_shortcutkey"),
                StateCode = (StateCode)entity.GetOptionSetValue("statecode"),
            };
        }

        private static Entity ConvertActionToEntity(USDAction usdAction)
        {
            return new Entity
            {
                Attributes =
                {
                    new KeyValuePair<string, object>("msdyusd_agentscriptactionid", usdAction.Id),
                    new KeyValuePair<string, object>("msdyusd_name", usdAction.Name),
                    new KeyValuePair<string, object>("msdyusd_order", usdAction.Order),
                    //EntityReferences
                    new KeyValuePair<string, object>("msdyusd_actiondata", usdAction.Data),
                    new KeyValuePair<string, object>("msdyusd_condition", usdAction.Condition),
                    new KeyValuePair<string, object>("msdyusd_shortcutkey", usdAction.ShortcutKey)
                }
            };
        }
    }
}
