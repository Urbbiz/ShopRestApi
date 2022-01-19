namespace ShopRestApi.Enteties
{
    public class ShopOwner
    {
        public int Id { get; set; }

        public string? Forename { get; set; }

        public string? Surname { get; set; }

        public List<ShopOwnerShop> Shops { get; set; }

    }
}
