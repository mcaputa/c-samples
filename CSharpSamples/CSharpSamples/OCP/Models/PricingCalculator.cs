using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSamples.POC.Models
{
    using System.Linq;

    using CSharpSamples.OCP.Models;

    public class PricingCalculator : IPricingCalculator
    {
        private readonly List<IPriceRule> priceRules;

        public PricingCalculator()
        {
            this.priceRules = new List<IPriceRule>();
            this.priceRules.Add(new EachPriceRule());
            this.priceRules.Add(new PerGramRule());
        }

        public decimal CalculatePrice(OrderItem item)
        {
            return this.priceRules.First(priceRule => priceRule.IsMatch(item)).CalculatePrice(item);
        }
    }
}
