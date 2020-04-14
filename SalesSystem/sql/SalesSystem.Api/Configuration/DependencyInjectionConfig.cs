using Microsoft.Extensions.DependencyInjection;
using SalesSystem.Business.Interfaces;
using SalesSystem.Business.Notifications;
using SalesSystem.Business.Services;
using SalesSystem.Data.Context;
using SalesSystem.Data.Repository;

namespace SalesSystem.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();

            return services;
        }
    }
}
