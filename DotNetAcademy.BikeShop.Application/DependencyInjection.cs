using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using DotNetAcademy.BikeShop.Application.Interfaces;
using DotNetAcademy.BikeShop.Application.Rules;
using MediatR;

namespace DotNetAcademy.BikeShop.Application
{
    [ExcludeFromCodeCoverage]
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterMediatR(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }

        public static IServiceCollection RegisterBusinessRules(this IServiceCollection services)
        {
            services.AddTransient<IDiscountRule, MultipleProductsPromotion>();
            return services;
        }
    }
}
