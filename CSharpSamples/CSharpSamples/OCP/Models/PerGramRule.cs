using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSamples.POC.Models
{
    using CSharpSamples.OCP.Models;

    public class PerGramRule : IPriceRule
    {
        public bool IsMatch(OrderItem item)
        {
            return item.Unit.StartsWith("GRAM");
        }

        public decimal CalculatePrice(OrderItem item)
        {
            var price = item.Quantity * 0.5m;
            return price;
        }
    }
}
