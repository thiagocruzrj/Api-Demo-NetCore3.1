using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace SalesSystem.Api.Configuration
{
    public static class ApiConfig
    {
        public static IServiceCollection WebConfig(this IServiceCollection services)
        {
            return services;
        }

        public static IApplicationBuilder UseMvcConfiguration(this IApplicationBuilder app)
        {
            return app;
        }
    }
}
