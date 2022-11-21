using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class OrderSummary
    {
        public double SubTotal { get; set; }
        public string? Shipping { get; set; }
        public double OrderTotal { get; set; }
    }
}
