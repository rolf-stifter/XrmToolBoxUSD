using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XRMToolboxUSD.Models;

namespace XRMToolboxUSD.Logic
{
    public static class Data
    {
        public static USDConfigurationData GetUSDConfigurationData(IOrganizationService service)
        {
            //var usdConfigData = new USDConfigurationData();

            //foreach (var hostedControl in Data.GetActiveHostedControls(service))
            //{
            //    var hostedControlModel = new HostedControl { Guid = hostedControl["uii_hostedapplicationid"].ToString(), Name = hostedControl["uii_name"].ToString() };

            //    //Console.WriteLine($"{hostedControlModel.Name}");

            //    //foreach (var usdEvent in Data.GetActiveEventsByHostedControlId(service, hostedControl["uii_hostedapplicationid"].ToString()))
            //    //{
            //    //    var usdEventModel = new Event { Guid = usdEvent["msdyusd_uiieventid"].ToString(), Name = usdEvent["msdyusd_name"].ToString() };

            //    //    //Console.WriteLine($"\t{usdEvent["msdyusd_name"]}");

            //    //    Data.GenerateActionTreeForEvent(service, usdEventModel);
            //    //    hostedControlModel.Events.Add(usdEventModel);
            //    //}

            //    usdConfigData.HostedControls.Add(hostedControlModel);
            //    break;
            //}

            //return usdConfigData;

            return new USDConfigurationData
            {
                HostedControls =
                {
                    new USDHostedControl
                    {
                        Name = "TestRolf",
                        Id = Guid.Empty
                    },
                    new USDHostedControl
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

        public static void GenerateActionTreeForEvent(IOrganizationService service, USDEvent usdEvent)
        {
            //foreach (var action in Data.GetActiveActionsByEventId(service, usdEvent))
            //{
            //    var actionModel = new Models.Action { Guid = action["msdyusd_agentscriptactionid"].ToString(), Name = action["msdyusd_name"].ToString() };
            //    //Console.WriteLine($"\t\t{action["msdyusd_name"]}");
            //    GenerateActionTreeForAction(service, actionModel, 3);
            //    usdEvent.Actions.Add(actionModel);
            //}
        }

        public static void GenerateActionTreeForAction(IOrganizationService service, Models.USDAction action, int indent)
        {
            //foreach (var subAction in Data.GetActiveActionsByActionId(service, action.Guid))
            //{
            //    var actionModel = new Models.USDAction { Id = subAction["msdyusd_agentscriptactionid"].ToString(), Name = subAction["msdyusd_name"].ToString() };
            //    //Console.WriteLine($"{String.Concat(Enumerable.Repeat("\t", indent))}{actionModel.Name}");
            //    GenerateActionTreeForAction(service, actionModel, indent + 1);
            //    action.SubActions.Add(actionModel);
            //}
        }
    }
}
