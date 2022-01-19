using ShopRestApi.Enteties.Base;

namespace ShopRestApi.Enteties
{
    public class Shop : Entity
    {
        public List<ShopItem>? ShopItems { get; set;}

        public List<ShopOwnerShop>? ShopOwnersShop { get; set;}
      
    }
}
