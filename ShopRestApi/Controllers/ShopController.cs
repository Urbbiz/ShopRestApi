using Microsoft.AspNetCore.Mvc;
using ShopRestApi.Data;
using ShopRestApi.Enteties;

namespace ShopRestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopController : ControllerBase
    {
        private readonly DataContext _context;

        public ShopController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Shop> GetAll()
        {
            return _context.Shops.ToList();
        }

        [HttpPost]
        public void Post(Shop entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }
    }
}
