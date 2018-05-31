using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XRMToolboxUSD.Models
{
    public class USDEventActionConnection
    {
        public Guid Id { get; set; }
        public Guid EventId { get; set; }
        public Guid ActionId { get; set; }
    }
}
