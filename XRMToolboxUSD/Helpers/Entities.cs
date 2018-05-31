using Microsoft.Xrm.Sdk;
using System;

namespace XRMToolboxUSD.Helpers
{
    public static class Entities
    {
        public static object GetValue(this Entity entity, string attributeName, object returnValue = null)
        {
            return entity.Contains(attributeName) && !string.IsNullOrEmpty(entity[attributeName].ToString())? entity[attributeName]:returnValue;
        }

        public static Guid GetEntityReferenceId(this Entity entity, string attributeName)
        {
            return entity.GetAttributeValue<EntityReference>(attributeName) != null ? entity.GetAttributeValue<EntityReference>(attributeName).Id : Guid.Empty;
        }

        public static string GetEntityReferenceName(EntityReference ef)
        {
            return ef != null ? ef.Name : null;
        }

        public static int GetOptionSetValue(this Entity entity, string attributeName){
            return entity.GetAttributeValue<OptionSetValue>(attributeName) != null ? entity.GetAttributeValue<OptionSetValue>(attributeName).Value : -1;
        }
    }
}