using ShopRestApi.Enteties.Base;

namespace ShopRestApi.Repositories
{
    public class MockGenericRepository<T> : IGenericRepository<T> where T : Entity
    {
        public Task Delete(int id)
        {
            return Task.CompletedTask;
        }

        public T FinidById(int id)
        {
            return null;
        }

        public Task<List<T>> GetAll()
        {
            return null;
        }

        public Task Post(T entity)
        {
            return null;
        }

        public Task Update(T entity)
        {
            return null;
        }
    }
}
