using ShopRestApi.Enteties;

namespace ShopRestApi.Interfaces
{
    public interface IToyRepository
    {
        Task Add(Toy toy);
        Task<List<Toy>> GetAll();
        Toy GetByName(string name);
    }
}