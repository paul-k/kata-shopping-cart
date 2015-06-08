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
            ISpecialPriceDiscounter discounter = new SpecialPriceDiscounter();
            cart = new Checkout(discounter);
        }

        [Test]
        public void When_Product_A_Is_Scanned_The_Value_Of_50_Is_Returned()
        {
            IProduct productA = new Product("A", 50);

            cart.Scan(productA);

            Assert.AreEqual(50, cart.GetTotal());
        }

        [Test]
        public void When_Product_B_Is_Scanned_The_Value_Of_30_Is_Returned()
        {
            IProduct productB = new Product("B", 30);

            cart.Scan(productB);

            Assert.AreEqual(30, cart.GetTotal());
        }

        [Test]
        public void When_Product_C_Is_Scanned_The_Value_Of_20_Is_Returned()
        {
            IProduct productC = new Product("C", 20);

            cart.Scan(productC);

            Assert.AreEqual(20, cart.GetTotal());
        }

        [Test]
        public void When_Product_D_Is_Scanned_The_Value_Of_15_Is_Returned()
        {
            IProduct productD = new Product("D", 15);

            cart.Scan(productD);

            Assert.AreEqual(15, cart.GetTotal());
        }

        [Test]
        public void When_Product_A_Is_Scanned_Three_Times_The_Value_Of_130_Is_Returned()
        {
            IProduct productA = new Product("A", 50);

            cart.Scan(productA);
            cart.Scan(productA);
            cart.Scan(productA);

            Assert.AreEqual(130, cart.GetTotal());
        }

        [Test]
        public void When_Product_B_Is_Scanned_Two_Times_The_Value_Of_45_Is_Returned()
        {
            IProduct productB = new Product("B", 30);

            cart.Scan(productB);
            cart.Scan(productB);

            Assert.AreEqual(45, cart.GetTotal());
        }

        [Test]
        public void When_Product_A_Is_Scanned_Six_Times_The_Discount_Is_Applied_Twice_And_The_Value_Of_260_Is_Returned()
        {
            IProduct productA = new Product("A", 50);

            cart.Scan(productA);
            cart.Scan(productA);
            cart.Scan(productA);

            cart.Scan(productA);
            cart.Scan(productA);
            cart.Scan(productA);

            Assert.AreEqual(260, cart.GetTotal());
        }
    }
}
