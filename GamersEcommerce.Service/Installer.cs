using GamersEcommerce.Domain.Interfaces.Services;
using GamersEcommerce.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GamersEcommerce.Service
{
    public static class Installer
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            return services;
        }
    }
}
