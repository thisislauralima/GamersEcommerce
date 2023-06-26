using GamersEcommerce.Infrastructure.RabbitMq;

namespace GamersEcommerce.WebApi.Model.RabbitMQSender
{
    public interface IRabbitMQMessageSender
    {
        void SendMessage(BaseMessage baseMessage, string queueName);
    }
}
