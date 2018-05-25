namespace CSharpSamples.POC
{
    using System.Collections.Generic;

    using CSharpSamples.POC.Models;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CartTest
    {
        private Cart cart;

        [TestInitialize]
        public void Setup()
        {
            this.cart = new Cart();
        }

        [TestMethod]
        public void TwoGram_ReturnPrice_One()
        {
            this.cart.AddItem(new OrderItem()
                                  {
                                      Unit = "GRAM_FLOUR",
                                      Quantity = 2
                                  });

            var price = this.cart.TotalAmount();

            Assert.AreEqual(1m, price);
        }

        [TestMethod]
        public void All_ReturnPrice_10()
        {
            this.cart.AddItem(new OrderItem()
                                  {
                                      Unit = "ALL_APPLES",
                                      Quantity = 4
                                  });

            var price = this.cart.TotalAmount();

            Assert.AreEqual(10, price);
        }
    }
}
