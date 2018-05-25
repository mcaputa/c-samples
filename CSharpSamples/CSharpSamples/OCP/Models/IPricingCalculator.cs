using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSamples.POC.Models
{
    public interface IPricingCalculator
    {
        decimal CalculatePrice(OrderItem item);
    }
}
