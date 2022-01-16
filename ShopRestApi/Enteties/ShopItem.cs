using ShopRestApi.Enteties.Base;

namespace ShopRestApi.Enteties
{
    public class ShopItem : Entity
    {
        public decimal Price { get; set; } = 0;

        public bool Deleted { get; set; } = false;

        public Shop? Shop { get; set; }

        public int ShopId { get; set; } 
    }
}
