using ShopRestApi.Enteties.Base;

namespace ShopRestApi.Enteties
{
    public class ShopItem : Entity
    {
        public decimal Price { get; set; } = 0.00M;

        public bool Deleted { get; set; } = false;

        public Shop? Shop { get; set; }

        public int ShopId { get; set; } 

        public string? Type { get; set; }

        public int Quantity { get; set; } = 1;
    }
}
