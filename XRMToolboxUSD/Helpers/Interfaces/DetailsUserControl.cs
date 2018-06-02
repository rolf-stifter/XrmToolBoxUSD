using XRMToolboxUSD.Models;

namespace XRMToolboxUSD.Helpers.Interfaces
{
    interface DetailsUserControl<T> where T : USDEntity
    {
        void FillDetails(T usdEntity);
    }
}
