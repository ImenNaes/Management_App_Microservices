using AutoMapper;
using Management.ManagementUI.Services.Base;
using ManagementUI.Models.Models;

namespace ManagementUI.Mapping_Profiles
{
    public class MappingConfig:Profile
    {
        public MappingConfig()
        {
            CreateMap<ProductDto, ProductVM>().ReverseMap();
        }
    }
}
