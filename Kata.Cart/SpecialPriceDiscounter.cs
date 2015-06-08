using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata.Cart
{
    public class SpecialPriceDiscounter : ISpecialPriceDiscounter
    {
        private IEnumerable<ISpecialPrice> _specialPrices;

        public SpecialPriceDiscounter(IEnumerable<ISpecialPrice> specialPrices)
        {
            _specialPrices = specialPrices;
        }

        public int GetTotalDiscount(IEnumerable<IProduct> products)
        {
            var totalDiscount = 0;

            foreach(var specialPrice in _specialPrices)
            {
                var occurances = products.Count(x => x.Sku == specialPrice.Sku);
                var multiplesOfDiscountToAdd = Math.Floor((double)occurances / specialPrice.ApplyOnOccurance);

                totalDiscount += (specialPrice.DiscountValue * (int)multiplesOfDiscountToAdd);
            }

            return totalDiscount;
        }
    }
}
