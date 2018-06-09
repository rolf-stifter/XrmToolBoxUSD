using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using XRMToolboxUSD.Helpers;
using XRMToolboxUSD.Helpers.Enums;

namespace XRMToolboxUSD.Repositories
{
    public static class ActionRepository
    {
        public static List<Models.CRM.Action> GetActions(IOrganizationService service)
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

        public static void UpdateAction(IOrganizationService service, Models.CRM.Action Action)
        {
            var entity = ConvertActionToEntity(Action);
            service.Update(entity);
        }

        private static Models.CRM.Action ConvertEntityToAction(Entity entity)
        {
            return new Models.CRM.Action
            {
                Id = entity.GetAttributeValue<Guid>("msdyusd_agentscriptactionid"),
                Name = entity.GetAttributeValue<string>("msdyusd_name"),
                Order = entity.GetAttributeValue<int>("msdyusd_order"),
                HostedControl = entity.GetAttributeValue<EntityReference>("msdyusd_application"),
                UIIAction = entity.GetAttributeValue<EntityReference>("msdyusd_action"),
                Data = entity.GetAttributeValue<string>("msdyusd_actiondata"),
                Condition = entity.GetAttributeValue<string>("msdyusd_condition"),
                ShortcutKey = entity.GetAttributeValue<string>("msdyusd_shortcutkey"),
                StateCode = (StateCode)entity.GetOptionSetValue("statecode"),
            };
        }

        private static Entity ConvertActionToEntity(Models.CRM.Action Action)
        {
            return new Entity
            {
                Attributes =
                {
                    new KeyValuePair<string, object>("msdyusd_agentscriptactionid", Action.Id),
                    new KeyValuePair<string, object>("msdyusd_name", Action.Name),
                    new KeyValuePair<string, object>("msdyusd_order", Action.Order),
                    //EntityReferences
                    new KeyValuePair<string, object>("msdyusd_actiondata", Action.Data),
                    new KeyValuePair<string, object>("msdyusd_condition", Action.Condition),
                    new KeyValuePair<string, object>("msdyusd_shortcutkey", Action.ShortcutKey)
                }
            };
        }
    }
}