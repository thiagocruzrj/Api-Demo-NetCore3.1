using Demo.Business.Interfaces;
using Demo.Business.Notifications;
using Demo.Business.Services;
using Demo.Data.Context;
using Demo.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Demo.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MyDbContext>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProviderRepository, ProviderRepository>();
            services.AddScoped<IAddressRepository, AddressRepository>();

            services.AddScoped<INotifier, Notifier>();
            services.AddScoped<IProviderService, ProviderRepository>();
            services.AddScoped<IProductService, ProductService>();

            return services;
        }
    }
}
