using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XRMToolboxUSD.Models
{
    public class USDActionSubActionConnection
    {
        public Guid Id { get; set; }
        public Guid ActionId { get; set; }
        public Guid SubActionId { get; set; }
    }
}
