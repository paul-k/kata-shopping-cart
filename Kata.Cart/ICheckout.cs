namespace Kata.Cart
{
    public interface ICheckout
    {
        void Scan(IProduct product);
        int GetTotal();
    }
}
