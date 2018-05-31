using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;

namespace XRMToolboxUSD.Logic
{
    public static class Starter
    {
        public static string WhoAmI(IOrganizationService service)
        {
            var request = new WhoAmIRequest();
            var response = (WhoAmIResponse)service.Execute(request);

            return $"{response.UserId} {response.ResponseName}";
        }
    }
}
