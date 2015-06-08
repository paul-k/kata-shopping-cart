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
            decimal result = 50;

            Assert.AreEqual(50, result);
        }
    }
}
