﻿namespace ShopRestApi.Enteties
{
    public class ShopOwnerShop
    {
        public int ShopId { get; set; }

        public Shop? Shop { get; set; }

        public int ShopOwnerId { get; set; }

        public ShopOwner? ShopOwner { get; set; }
    }
}
