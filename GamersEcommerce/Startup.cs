using GamersEcommerce.Infrastructure.Oracle.Extensions;

namespace GamersEcommerce.WebApi
{
    public class Startup
    {
        public virtual void ConfigureServices(IServiceCollection services)
        {
            services.AddOracleDbContext();
        }
    }
}