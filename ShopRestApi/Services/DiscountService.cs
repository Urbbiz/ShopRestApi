namespace ShopRestApi.Services
{
    public class DiscountService
    {
        private const int discountPercent = 10;

        public decimal CalculateDiscount(decimal price)
        {
            return price / 100 * 10;
        }
    }
}
