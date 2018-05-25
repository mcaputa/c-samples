using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSamples.POC.Models
{
    using CSharpSamples.OCP.Models;

    public class EachPriceRule : IPriceRule
    {
        public bool IsMatch(OrderItem item)
        {
            return item.Unit.StartsWith("ALL");
        }

        public decimal CalculatePrice(OrderItem item)
        {
            var price = item.Quantity * 2.5m;
            return price;
        }
    }
}
