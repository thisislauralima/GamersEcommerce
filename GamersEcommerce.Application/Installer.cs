using GamersEcommerce.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace GamersEcommerce.Application
{
    public static class Installer
    {
        public static IServiceCollection AddApplicationDependecyInjection(this IServiceCollection services)
        {
            return services
                .AddScoped<IProductCase, ProductCase>();
        }
    }
}
