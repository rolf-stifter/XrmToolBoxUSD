using System;
using XRMToolboxUSD.Helpers.Enums;

namespace XRMToolboxUSD.Models.CRM
{
    public abstract class USDEntity
    {
        #region General
        public Guid Id { get; set; }
        public string Name { get; set; }
        public StateCode StateCode { get; set; }
        #endregion
    }
}