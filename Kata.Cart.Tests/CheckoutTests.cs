using System;
using NUnit.Framework;

namespace Kata.Cart.Tests
{
    [TestFixture]
    public class CheckoutTests
    {
        [Test]
        public void When_Product_A_Is_Scanned_The_Value_Of_50_Is_Returned()
        {
            var cart = new Checkout();
            cart.Scan("A");

            Assert.AreEqual(50, cart.GetTotal());
        }

        [Test]
        public void When_Product_B_Is_Scanned_The_Value_Of_30_Is_Returned()
        {
            var cart = new Checkout();
            cart.Scan("B");

            Assert.AreEqual(30, cart.GetTotal());
        }
    }
}
