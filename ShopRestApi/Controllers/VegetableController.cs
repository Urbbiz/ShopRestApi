//using AutoMapper;
//using Microsoft.AspNetCore.Mvc;
//using ShopRestApi.Controllers.Base;
//using ShopRestApi.Dtos;
//using ShopRestApi.Enteties;
//using ShopRestApi.Repositories;

//namespace ShopRestApi.Controllers 
//{
//    [ApiController]
//    [Route("[controller]")]
//    public class VegetableController : ControllerBase
//    {
//        private readonly IMapper _mapper;
//        private readonly IGenericRepository<ShopItem> _repository;


//        public VegetableController(IMapper mapper, IGenericRepository<ShopItem> repository)
//        {
//            _mapper = mapper;
//            _repository = repository;
//        }

//        [HttpGet]
//        public async virtual Task<List<VegetableDto>> GetAll()
//        {
//            // var enteties = await _context.ShopItems.ToListAsync();
//            var enteties = await _repository.GetAll();
//            var dto = _mapper.Map<List<VegetableDto>>(enteties);
//            return dto;
//        }

//        [HttpGet("{id}")]
//        public VegetableDto GetById(int id)
//        {
//            var entity = _repository.FinidById(id);
//            return _mapper.Map<VegetableDto>(entity);
//        }

//        [HttpPost]
//        public async Task Post(VegetableDto item)
//        {
//            var entity = _mapper.Map<ShopItem>(item);
//            await _repository.Post(entity);
//        }

//        [HttpPut]
//        public async Task Update(VegetableDto item)
//        {
//            var entity = _mapper.Map<ShopItem>(item);
//            ;
//            await _repository.Update(entity);
//        }

//        [HttpDelete("{id}")]
//        public async Task Delete(int id)
//        {
//            await _repository.Delete(id);
//        }


//    }
//}
