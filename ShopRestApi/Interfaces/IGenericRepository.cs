using ShopRestApi.Enteties.Base;

namespace ShopRestApi.Interfaces
{
    public interface IGenericRepository<T> where T : Entity
    {
        Task Delete(int id);
        T FinidById(int id);
        Task<List<T>> GetAll();
        Task Post(T entity);
        Task Update(T entity);
    }
}