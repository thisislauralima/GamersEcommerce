using Ecommerce.Infrastructure.Oracle;
using GamersEcommerce.Domain.Interfaces;
using GamersEcommerce.Infrastructure.Oracle.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace GamersEcommerce.Infrastructure.Oracle.Extensions
{
    public static class OracleExtensions
    {
        public static IServiceCollection AddOracleDbContext(this IServiceCollection services)
        {
            return services
                .AddDbContext<OracleDbContext>() // pesquisar essa parte
                .AddOracleRepositories();
        }

        public static IServiceCollection AddOracleRepositories(this IServiceCollection services)
        {
            return services
                .AddScoped<IBaseRepository, BaseRepository>();
        }
    }
}