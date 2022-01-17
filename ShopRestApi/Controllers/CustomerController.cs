using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopRestApi.Controllers.Base;
using ShopRestApi.Data;
using ShopRestApi.Dtos;
using ShopRestApi.Enteties;
using ShopRestApi.Repositories;

namespace ShopRestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : GenericControllerBase<CustomerDto, Customer>
    {
        public CustomerController(IMapper mapper, GenericRepository<Customer> repository) : base(mapper, repository)
        {
        }
    }
}
