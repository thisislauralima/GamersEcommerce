using GamersEcommerce.WebApi.Model.RabbitMQSender;
using Microsoft.Extensions.DependencyInjection;

namespace GamersEcommerce.Infrastructure.RabbitMq
{
    public static class Installer
    {
        public static IServiceCollection AddRabbitMqDependecyInjection(this IServiceCollection services)
        {
            return services.AddSingleton<IRabbitMQMessageSender, RabbitMQMessageSender>();
        }
    }
}
