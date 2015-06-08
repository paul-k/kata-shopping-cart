using System.Collections.Generic;

namespace Kata.Cart
{
    public interface ISpecialPriceDiscounter
    {
        int GetTotalDiscount(IEnumerable<IProduct> products);
    }
}
