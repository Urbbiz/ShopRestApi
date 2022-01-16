using Microsoft.AspNetCore.Mvc;
using ShopRestApi.Data;
using ShopRestApi.Enteties;

namespace ShopRestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopItemController : ControllerBase
    {
        private readonly DataContext _context;

        public ShopItemController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<ShopItem> GetAll()
        {
            return _context.ShopItems.ToList();
        }

        [HttpPost]
        public void Post(ShopItem item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }
    }
}
