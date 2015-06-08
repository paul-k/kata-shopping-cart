namespace Kata.Cart
{
    public interface ICheckout
    {
        void Scan(string sku);
        int GetTotal();
    }
}
