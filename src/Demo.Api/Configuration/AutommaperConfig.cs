using AutoMapper;
using Demo.Api.ViewModels;
using Demo.Business.Models;

namespace Demo.Api.Configuration
{
    public class AutommaperConfig : Profile
    {
        public AutommaperConfig()
        {
            CreateMap<Provider, ProviderViewModel>().ReverseMap();
            CreateMap<Address, AddressViewModel>().ReverseMap();
            CreateMap<ProductViewModel, Product>();

            CreateMap<Product, ProductViewModel>()
                .ForMember(dest => dest.ProviderName, opt => opt.MapFrom(src => src.Provider.Name));
        }
    }
}
