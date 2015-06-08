namespace Kata.Cart
{
    public interface ISpecialPrice
    {
        string Sku { get; }
        int ApplyOnOccurance { get; }
        int DiscountValue { get; }
    }
}
