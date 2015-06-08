using System.Collections.Generic;
using System.Linq;

namespace Kata.Cart
{
    public class Checkout : ICheckout
    {
        private int total = 0;
        private List<IProduct> items = new List<IProduct>();

        public void Scan(IProduct product)
        {
            items.Add(product);

            total += product.Value;
        }

        public int GetTotal()
        {
            var discount = GetDiscount();

            return total - discount;
        }

        private int GetDiscount()
        {
            var totalDiscount = 0;

            var occuranceOfProductA = items.Count(x => x.Sku == "A");
            if (occuranceOfProductA == 3)
            {
                totalDiscount += 20;
            }

            var occuranceOfProductB = items.Count(x => x.Sku == "B");
            if (occuranceOfProductB == 2)
            {
                totalDiscount += 15;
            }

            return totalDiscount;
        }
    }
}
