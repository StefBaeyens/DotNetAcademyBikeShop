using System.Diagnostics.CodeAnalysis;
using AutoMapper;
using DotNetAcademy.BikeShop.Application.Interfaces;
using DotNetAcademy.BikeShop.Application.Queries;
using DotNetAcademy.BikeShop.Infrastructure.Behaviour;
using DotNetAcademy.BikeShop.Infrastructure.Mapping;
using DotNetAcademy.BikeShop.Infrastructure.Models;
using DotNetAcademy.BikeShop.Infrastructure.Persistence;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetAcademy.BikeShop.Infrastructure
{
    [ExcludeFromCodeCoverage]
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ModelViewModelProfile));
            return services;
        }


        public static IServiceCollection RegisterPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<BikeShopDbContext>();
            services.AddDbContext<IBikeShopDbContext, BikeShopDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("BikeShopDb")));
            return services;
        }

        public static IServiceCollection RegisterFluentValidations(this IServiceCollection services)
        {
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            AssemblyScanner.FindValidatorsInAssemblyContaining<GetProductsQuery>().ForEach(result =>
            {
                services.AddTransient(result.InterfaceType, result.ValidatorType);
            });
            return services;
        }

        public static IServiceCollection RegisterIdentity(this IServiceCollection services)
        {
            services.AddIdentity<Customer, IdentityRole>()
                .AddEntityFrameworkStores<BikeShopDbContext>()
                .AddDefaultTokenProviders();
            return services;
        }
    }
}
