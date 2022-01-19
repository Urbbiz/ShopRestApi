using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopRestApi.Controllers.Base;
using ShopRestApi.Data;
using ShopRestApi.Dtos;
using ShopRestApi.Enteties;
using ShopRestApi.Repositories;
using ShopRestApi.Services;

namespace ShopRestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopItemController : GenericControllerBase<ShopItemDto, ShopItem>
    {
        private readonly IMapper _mapper;
        private readonly GenericRepository<ShopItem> _repository;
        private readonly PriceCalculationService _priceCalculationService;

        public ShopItemController(IMapper mapper, GenericRepository<ShopItem> repository, PriceCalculationService priceCalculationService) : base(mapper, repository)
        {
            _mapper = mapper;
            _repository = repository;
            _priceCalculationService = priceCalculationService;
        }

        [HttpGet]
        public async override Task<List<ShopItemDto>> GetAll()
        {
            var enteties = await _repository.GetAll();

            var dtos = _mapper.Map<List<ShopItemDto>>(enteties);

            var updatedDtos = dtos.Select(d => _priceCalculationService.ApplyDiscount(d));


            return dtos;

        }
    }

}
