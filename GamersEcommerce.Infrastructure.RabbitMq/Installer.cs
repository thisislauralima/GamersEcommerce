using GamersEcommerce.Infrastructure.RabbitMq.Model.RabbitMQSender;
using Microsoft.Extensions.DependencyInjection;

namespace GamersEcommerce.Infrastructure.RabbitMq
{
    public static class Installer
    {
        public static IServiceCollection AddRabbitMqDependecyInjection(this IServiceCollection services)
        {
            services.AddSingleton<IRabbitMQMessageSender, RabbitMQMessageSender>();
            return services;
        }
    }
}
