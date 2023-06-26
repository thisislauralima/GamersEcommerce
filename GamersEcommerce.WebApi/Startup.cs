using GamersEcommerce.Application;
using GamersEcommerce.Infrastructure.Oracle.Extensions;
using GamersEcommerce.Infrastructure.RabbitMq;
using GamersEcommerce.WebApi.DependencyInjection;

namespace GamersEcommerce.WebApi
{
    public class Startup
    {
        public virtual void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddOracleDbContext();
            services.AddOracleRepositories();
            services.AddRabbitMqDependecyInjection();
            services.AddApplicationDependecyInjection();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app
                .UseRouting()
                .UseAuthentication()
                .UseSwaggerConfiguration()
                .UseEndpoints(endpoints => endpoints.MapControllers()); // sem essa linha o swagger não exibe mensagem de erro no retorno
        }
    }
}