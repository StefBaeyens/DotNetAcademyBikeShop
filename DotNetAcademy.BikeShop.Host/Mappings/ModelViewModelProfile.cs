using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DotNetAcademy.BikeShop.Host.Helpers;
using DotNetAcademy.BikeShop.Host.Models;
using DotNetAcademy.BikeShop.Host.ViewModels;

namespace DotNetAcademy.BikeShop.Host.Mappings
{
    public class ModelViewModelProfile : Profile
    {
        public ModelViewModelProfile()
        {
            CreateMap<Product, ProductViewModel>().ForMember(model => model.PathToImage, opt => opt.MapFrom(_ => "/images/bikes/" + BikeImageHelper.GetRandomImage()));
        }
    }
}
