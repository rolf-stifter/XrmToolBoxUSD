using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using XRMToolboxUSD.Models.CRM;
using XRMToolboxUSD.Models.Custom;

namespace XRMToolboxUSD.Logic
{
    public static class Data
    {
        public static USDConfigurationData GetUSDConfigurationData(IOrganizationService service)
        {
            return new USDConfigurationData
            {
                HostedControls =
                {
                    new HostedControl
                    {
                        Name = "TestRolf",
                        Id = Guid.Empty
                    },
                    new HostedControl
                    {
                        Name = "TestRolf2",
                        Id = Guid.Empty
                    }
                }
            };
        }

        public static DataCollection<Entity> GetActiveEventsByHostedControlId(IOrganizationService service, string guid)
        {
            QueryExpression activeEventsByHostedControlQuery = new QueryExpression
            {
                EntityName = "msdyusd_uiievent",
                ColumnSet = new ColumnSet("msdyusd_uiieventid", "msdyusd_name"),
                Criteria = new FilterExpression
                {
                    Conditions =
                        {
                            new ConditionExpression
                            {
                                AttributeName = "msdyusd_hostedapplicationid",
                                Operator = ConditionOperator.Equal,
                                Values = { guid }
                            },
                            new ConditionExpression
                            {
                                AttributeName = "statecode",
                                Operator = ConditionOperator.Equal,
                                Values = { 0 }
                            }
                        }
                }
            };

            return service.RetrieveMultiple(activeEventsByHostedControlQuery).Entities;
        }

        public static DataCollection<Entity> GetActiveActionsByEventId(IOrganizationService service, string guid)
        {
            QueryExpression activeActionsByEventQuery = new QueryExpression
            {
                EntityName = "msdyusd_agentscriptaction",
                ColumnSet = new ColumnSet("msdyusd_agentscriptactionid", "msdyusd_name"),
                Criteria = new FilterExpression
                {
                    Conditions =
                        {
                            new ConditionExpression
                            {
                                AttributeName = "statecode",
                                Operator = ConditionOperator.Equal,
                                Values = { 0 }
                            }
                        }
                },
                LinkEntities =
                {
                    new LinkEntity
                    {
                        LinkFromEntityName = "msdyusd_agentscriptaction",
                        LinkFromAttributeName = "msdyusd_agentscriptactionid",
                        LinkToEntityName = "msdyusd_uiievent_agentscriptaction",
                        LinkToAttributeName = "msdyusd_agentscriptactionid",
                        LinkCriteria = new FilterExpression
                        {
                            Conditions =
                            {
                                new ConditionExpression
                                {
                                    AttributeName = "msdyusd_uiieventid",
                                    Operator = ConditionOperator.Equal,
                                    Values = { guid }
                                }
                            }
                        }
                    }
                }
            };

            return service.RetrieveMultiple(activeActionsByEventQuery).Entities;
        }

        public static DataCollection<Entity> GetActiveActionsByActionId(IOrganizationService service, string guid)
        {
            QueryExpression activeActionsByActionQuery = new QueryExpression
            {
                EntityName = "msdyusd_agentscriptaction",
                ColumnSet = new ColumnSet("msdyusd_agentscriptactionid", "msdyusd_name"),
                Criteria = new FilterExpression
                {
                    Conditions =
                        {
                            new ConditionExpression
                            {
                                AttributeName = "statecode",
                                Operator = ConditionOperator.Equal,
                                Values = { 0 }
                            }
                        }
                },
                LinkEntities =
                {
                    new LinkEntity
                    {
                        LinkFromEntityName = "msdyusd_agentscriptaction",
                        LinkFromAttributeName = "msdyusd_agentscriptactionid",
                        LinkToEntityName = "msdyusd_subactioncalls",
                        LinkToAttributeName = "msdyusd_agentscriptactionidone",
                        LinkCriteria = new FilterExpression
                        {
                            Conditions =
                            {
                                new ConditionExpression
                                {
                                    AttributeName = "msdyusd_agentscriptactionidtwo",
                                    Operator = ConditionOperator.Equal,
                                    Values = { guid }
                                }
                            }
                        }
                    }
                }
            };

            return service.RetrieveMultiple(activeActionsByActionQuery).Entities;
        }
    }
}