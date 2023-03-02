using AutoMapper;
using Management.BLL.Contracts.CQRS.Commands;
using Management.BLL.Contracts.DTO;
using Management.Domain;

namespace Management.BLL.Application.MappingProfiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<AddProductCommand, Product>().ReverseMap();
            CreateMap<UpdateProductCommand, Product>();
        }
    }
}
