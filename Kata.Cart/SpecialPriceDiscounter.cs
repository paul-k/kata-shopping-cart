using System.Linq;
using System.Collections.Generic;

namespace Kata.Cart
{
    public class SpecialPriceDiscounter : ISpecialPriceDiscounter
    {
        public int GetTotalDiscount(IEnumerable<IProduct> products)
        {
            var totalDiscount = 0;

            var occuranceOfProductA = products.Count(x => x.Sku == "A");
            if (occuranceOfProductA == 3)
            {
                totalDiscount += 20;
            }

            var occuranceOfProductB = products.Count(x => x.Sku == "B");
            if (occuranceOfProductB == 2)
            {
                totalDiscount += 15;
            }

            return totalDiscount;
        }
    }
}
