using Microsoft.EntityFrameworkCore;
using ShopRestApi.Data;
using ShopRestApi.Enteties.Base;

namespace ShopRestApi.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : Entity
    {
        private readonly DataContext _context;

        public GenericRepository(DataContext context)
        {
            _context = context ?? throw new ArgumentException(nameof(context));
        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task Post(T entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }

        public T FinidById(int id)
        {
            var entity = _context.Set<T>().FirstOrDefault(e => e.Id == id);
            if (entity == null)
            {
                throw new ArgumentException("");
            }
            return entity;
        }

        public async Task Delete(int id)
        {
            var entity = _context.Set<T>().FirstOrDefault(e => e.Id == id);

            if (entity != null)
            {
                _context.Remove(entity);
            }
            await _context.SaveChangesAsync();
        }
    }
}
