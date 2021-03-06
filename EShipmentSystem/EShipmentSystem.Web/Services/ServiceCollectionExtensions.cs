﻿namespace EShipmentSystem.Web.Services
{
    using Microsoft.Extensions.DependencyInjection;
    using AutoMapper;

    using Data.Repositories;
    using Infrastructure.Mappings;

    using EShipmentSystem.Services.Contracts;
    using EShipmentSystem.Services;

    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddScoped<IAdditionalOptionsService, AdditionalOptionsService>();
            services.AddScoped<IReceiverService, ReceiverService>();
            services.AddScoped<IShipmentDataService, ShipmentDataService>();

            services.AddScoped<IMapper>(sp => ConfigurateAutoMapper(services).CreateMapper());

            return services;
        }

        private static MapperConfiguration ConfigurateAutoMapper(IServiceCollection services)
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new EShipmentSystemMappingProfile());
            });
        }
    }
}
