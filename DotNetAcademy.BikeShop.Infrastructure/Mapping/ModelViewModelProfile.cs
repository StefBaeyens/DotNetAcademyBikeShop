using AutoMapper;
using DotNetAcademy.BikeShop.Application.ViewModels;
using DotNetAcademy.BikeShop.Domain.Models;
using DotNetAcademy.BikeShop.Infrastructure.Helpers;

namespace DotNetAcademy.BikeShop.Infrastructure.Mapping
{
    public class ModelViewModelProfile : Profile
    {
        public ModelViewModelProfile()
        {
            CreateMap<Product, ProductViewModel>().ForMember(model => model.PathToImage, opt => opt.MapFrom(_ => "/images/bikes/" + BikeImageHelper.GetRandomImage()));
            CreateMap<ShoppingBag, ShoppingBagViewModel>().ForMember(model => model.Total, opt => opt.Ignore()).ForMember(model => model.TotalDiscount, opt => opt.Ignore());
            CreateMap<ShoppingItem, ShoppingItemViewModel>().ForMember(model => model.Total, opt => opt.Ignore());
        }
    }
}
