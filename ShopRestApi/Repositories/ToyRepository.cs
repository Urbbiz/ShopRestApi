using Microsoft.EntityFrameworkCore;
using ShopRestApi.Data;
using ShopRestApi.Enteties;
using ShopRestApi.Interfaces;

namespace ShopRestApi.Repositories
{
    public class ToyRepository : IToyRepository
    {
        private readonly DataContext _context;

        public ToyRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Toy>> GetAll()
        {
            return await _context.Toys.ToListAsync();

        }

        public async Task Add(Toy toy)
        {
            _context.Add(toy);
            await _context.SaveChangesAsync();
        }

        public Toy GetByName(string name)
        {
            return _context.Toys.FirstOrDefault(s => s.Name == name);
        }

        public async Task Delete(int id)
        {
           var item = _context.Toys.FirstOrDefault(s => s.Id == id);

            _context.Remove(item);

            await _context.SaveChangesAsync();
        }
    }
}
