using ShopRestApi.Enteties;

namespace ShopRestApi.Services
{
    public class DiscountService
    {
        private const int discountPercent = 10;

        public decimal CalculateDiscount(decimal price)
        {
            return price / 100 * 10;
        }

        public decimal GetDiscountedPrice(Toy item, int quantity)
        {
            var fullPrice = item.Price * quantity;

            if (quantity >= 5)
            {
                return fullPrice - ( fullPrice / 100.0M * 20);
            }
            else
            {
                return fullPrice - (fullPrice / 100.0M * 10);
            }
        }
    }
}
