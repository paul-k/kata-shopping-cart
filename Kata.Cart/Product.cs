namespace Kata.Cart
{
    public class Product : IProduct
    {
        private string _sku;
        private int _value;

        public Product(string sku, int value)
        {
            _sku = sku;
            _value = value;
        }

        public string Sku
        {
            get { return _sku; }
        }

        public int Value
        {
            get { return _value; }
        }
    }
}
