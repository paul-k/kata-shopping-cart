using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Cart
{
    public class SpecialPrice : ISpecialPrice
    {
        private string _sku;
        private int _applyOnOccurance;
        private int _discountValue;

        public SpecialPrice(string sku, int applyOnOccurance, int discountValue)
        {
            _sku = sku;
            _applyOnOccurance = applyOnOccurance;
            _discountValue = discountValue;
        }

        public string Sku
        {
            get { return _sku; }
        }

        public int ApplyOnOccurance
        {
            get { return _applyOnOccurance; }
        }

        public int DiscountValue
        {
            get { return _discountValue; }
        }
    }
}
