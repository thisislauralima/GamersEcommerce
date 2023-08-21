using GamersEcommerce.Domain.Interfaces.Application.UseCases;
using Microsoft.Extensions.DependencyInjection;

namespace GamersEcommerce.Application
{
    public static class Installer
    {
        public static IServiceCollection AddApplicationDependecyInjection(this IServiceCollection services)
        {
            services
                .AddScoped<IProductCase, ProductCase>();

            return services;
        }
    }
}
