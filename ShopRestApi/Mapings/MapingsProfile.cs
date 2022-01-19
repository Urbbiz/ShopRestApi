using AutoMapper;
using ShopRestApi.Dtos;
using ShopRestApi.Enteties;

namespace ShopRestApi.Mapings
{
    public class MapingsProfile : Profile
    {
        public MapingsProfile()
        {
         

            CreateMap<ShopItemDto, ShopItem>().ReverseMap();

            CreateMap<ShopDto, Shop>().ReverseMap();

            CreateMap<CustomerDto, Customer>().ReverseMap();
        }
        
    }
}
