using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopRestApi.Data;
using ShopRestApi.Dtos;
using ShopRestApi.Enteties;
using ShopRestApi.Interfaces;
using ShopRestApi.Repositories;
using ShopRestApi.Services;

namespace ShopRestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToyController : ControllerBase
    {
        private readonly IToyRepository _repository;

        private readonly DiscountService _discountService;

        public ToyController(IToyRepository repository, DiscountService discountService)
        {
            _repository = repository;
            _discountService = discountService;
        }

        [HttpGet]
        public async Task<List<Toy>> GetAll()
        {
            var items = await _repository.GetAll();

            items.ForEach(i => i.Price = _discountService.GetDiscountedPrice(i, 1));

            return items;
        }

        [HttpPost]
        public async Task Create(Toy toy)
        {

            await _repository.Add(toy);
        }

        [HttpPost("/Buy")]
        public decimal Buy(BuyToyDto toyDto)
        {
            var item = _repository.GetByName(toyDto.Name);

            return _discountService.GetDiscountedPrice(item, toyDto.Quantity);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {

            await _repository.Delete(id);
        }
    }
}
