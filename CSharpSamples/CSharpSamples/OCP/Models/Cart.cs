using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSamples.POC.Models
{
    public class Cart
    {
        // just for example, here should be DI
        public Cart()
        {
            this.PriceCalculator = new PricingCalculator();
            this.OrderItems = new List<OrderItem>();
        }
        
        public IPricingCalculator PriceCalculator { get; }

        public List<OrderItem> OrderItems { get; }

        public void AddItem(OrderItem item)
        {
            this.OrderItems.Add(item);
        }

        public decimal TotalAmount()
        {
            decimal totalAmount = 0;

            foreach (var orderItem in this.OrderItems)
            {
                totalAmount += this.PriceCalculator.CalculatePrice(orderItem);
            }

            return totalAmount;
        }
    }
}
