using System;
using NUnit.Framework;

namespace Kata.Cart.Tests
{
    [TestFixture]
    public class CheckoutTests
    {
        private ICheckout cart;

        [SetUp]
        public void SetupForTests()
        {
            cart = new Checkout();
        }

        [Test]
        public void When_Product_A_Is_Scanned_The_Value_Of_50_Is_Returned()
        {
            cart.Scan("A");

            Assert.AreEqual(50, cart.GetTotal());
        }

        [Test]
        public void When_Product_B_Is_Scanned_The_Value_Of_30_Is_Returned()
        {
            cart.Scan("B");

            Assert.AreEqual(30, cart.GetTotal());
        }

        [Test]
        public void When_Product_C_Is_Scanned_The_Value_Of_20_Is_Returned()
        {
            cart.Scan("C");

            Assert.AreEqual(20, cart.GetTotal());
        }

        [Test]
        public void When_Product_D_Is_Scanned_The_Value_Of_15_Is_Returned()
        {
            cart.Scan("D");

            Assert.AreEqual(15, cart.GetTotal());
        }

        [Test]
        public void When_Product_A_Is_Scanned_Three_Times_The_Value_Of_130_Is_Returned()
        {
            cart.Scan("A");
            cart.Scan("A");
            cart.Scan("A");

            Assert.AreEqual(130, cart.GetTotal());
        }
    }
}
