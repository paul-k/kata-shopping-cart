using System.Collections.Generic;
using System.Linq;

namespace Kata.Cart
{
    public class Checkout : ICheckout
    {
        private int total = 0;
        private List<string> items = new List<string>();

        public void Scan(string sku)
        {
            items.Add(sku);

            switch(sku)
            {
                case "A":
                    total += 50;
                    break;
                case "B":
                    total += 30;
                    break;
                case "C":
                    total += 20;
                    break;
                case "D":
                    total += 15;
                    break;
                default:
                    break;
            }
        }

        public int GetTotal()
        {
            var discount = GetDiscount();

            return total - discount;
        }

        private int GetDiscount()
        {
            var totalDiscount = 0;

            var occuranceOfProductA = items.Count(x => x == "A");
            if (occuranceOfProductA == 3)
            {
                totalDiscount += 20;
            }

            return totalDiscount;
        }
    }
}
