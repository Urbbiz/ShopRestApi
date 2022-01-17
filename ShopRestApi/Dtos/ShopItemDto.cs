using ShopRestApi.Dtos.Base;

namespace ShopRestApi.Dtos
{
    public class ShopItemDto : DtoObject
    {
        public int ShopId { get; set; }

        public decimal Price { get; set; }
    }
}
