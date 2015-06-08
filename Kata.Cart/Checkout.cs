namespace Kata.Cart
{
    public class Checkout : ICheckout
    {
        private int total = 0;

        public void Scan(string sku)
        {
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
            return total;
        }
    }
}
