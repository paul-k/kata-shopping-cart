using System.Collections.Generic;
using System.Linq;

namespace Kata.Cart
{
    public class Checkout : ICheckout
    {
        private int _total;
        private List<IProduct> _items;
        private ISpecialPriceDiscounter _discounter;

        public Checkout(ISpecialPriceDiscounter discounter)
        {
            _total = 0;
            _items = new List<IProduct>();
            _discounter = discounter;
        }

        public void Scan(IProduct product)
        {
            _items.Add(product);

            _total += product.Value;
        }

        public int GetTotal()
        {
            var discount = _discounter.GetTotalDiscount(_items);

            return _total - discount;
        }
    }
}
