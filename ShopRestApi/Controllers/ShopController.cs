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
    public class ShopController : GenericControllerBase<ShopDto, Shop>
    {
        public ShopController(IMapper mapper, GenericRepository<Shop> repository) : base(mapper, repository)
        {
        }

        [HttpPost("{id}/Buy")]
        public IActionResult Post2(int id)
        {
            return NoContent();
        }


    }
}
