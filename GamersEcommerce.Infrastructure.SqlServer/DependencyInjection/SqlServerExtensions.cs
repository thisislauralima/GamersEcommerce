using GamersEcommerce.Domain.Interfaces.Repositories;
using GamersEcommerce.Infrastructure.SqlServer.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace GamersEcommerce.Infrastructure.SqlServer.DependencyInjection
{
    public static class SqlServerExtensions
    {
        public static IServiceCollection AddSqlServerDbContext(this IServiceCollection services)
        {
            services
                .AddDbContext<SqlServerDbContext>()
                .AddSqlServerRepositories();
            return services;
        }

        public static IServiceCollection AddSqlServerRepositories(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            return services;
        }
    }
}
