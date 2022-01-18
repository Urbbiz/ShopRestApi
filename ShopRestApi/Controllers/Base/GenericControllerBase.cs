using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopRestApi.Dtos.Base;
using ShopRestApi.Enteties.Base;
using ShopRestApi.Repositories;

namespace ShopRestApi.Controllers.Base
{
    public class GenericControllerBase<TDto, TEntity> : ControllerBase where TDto : DtoObject where TEntity : Entity
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<TEntity> _repository;


        public GenericControllerBase(IMapper mapper, IGenericRepository<TEntity> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        [HttpGet]
        public async virtual Task<List<TDto>> GetAll()
        {
            // var enteties = await _context.ShopItems.ToListAsync();
            var enteties = await _repository.GetAll();
            var dto = _mapper.Map<List<TDto>>(enteties);
            return dto;
        }

        [HttpGet("{id}")]
        public TDto GetShop(int id)
        {
            var entity = _repository.FinidById(id);
            return _mapper.Map<TDto>(entity);
        }

        [HttpPost]
        public async Task Post(TDto item)
        {
            var entity = _mapper.Map<TEntity>(item);
            await _repository.Post(entity);
        }

        [HttpPut]
        public async Task Update(TDto item)
        {
            var entity = _mapper.Map<TEntity>(item);
            ;
            await _repository.Update(entity);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _repository.Delete(id);
            //var shop = _context.Shops.FirstOrDefault(s => s.id == id);

            //if(shop != null)
            //{
            //    _context.Remove(shop);
            //   await _context.SaveChangesAsync();
            //}
        }
    }
}
