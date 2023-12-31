﻿using GamersEcommerce.Application;
using GamersEcommerce.Infrastructure.RabbitMq;
using GamersEcommerce.WebApi.DependencyInjection;
using GamersEcommerce.WebApi.DependencyInjection.Middleware;
using GamersEcommerce.Service;
using GamersEcommerce.Infrastructure.SqlServer.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace GamersEcommerce.WebApi
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup()
        {
            _configuration = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        }
        public virtual void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddSqlServerDbContext();
            services.AddApplicationDependecyInjection();
            services.AddServices();
            services.AddRabbitMqDependecyInjection();
            services.AddAuthenticationConfig(_configuration);
            //services.AddAuthenticationConfig(_configuration);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app
                .UseRouting()
                .UseSwaggerConfiguration()
                .UseAuthentication()
                .UseAuthorization()
                .UseEndpoints(endpoints => endpoints.MapControllers()); // sem essa linha o swagger não exibe mensagem de erro no retorno
        }
    }
}