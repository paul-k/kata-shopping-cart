using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata.Cart
{
    public class SpecialPriceDiscounter : ISpecialPriceDiscounter
    {
        public int GetTotalDiscount(IEnumerable<IProduct> products)
        {
            var totalDiscount = 0;

            var occuranceOfProductA = products.Count(x => x.Sku == "A");
            var multiplesOfDiscountToAdd = Math.Floor((double)occuranceOfProductA / 3);

            totalDiscount += (20 * (int)multiplesOfDiscountToAdd);
            

            var occuranceOfProductB = products.Count(x => x.Sku == "B");
            if (occuranceOfProductB == 2)
            {
                totalDiscount += 15;
            }

            return totalDiscount;
        }
    }
}
