using Microsoft.AspNetCore.Mvc;
using ShopRestApi.Data;
using ShopRestApi.Enteties;

namespace ShopRestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly DataContext _context;

        public CustomerController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        [HttpPost]  
        public void Post(Customer entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }
    }
}
