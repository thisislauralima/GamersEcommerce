using GamersEcommerce.Infrastructure.RabbitMq;

namespace GamersEcommerce.Infrastructure.RabbitMq.Model.RabbitMQSender
{
    public interface IRabbitMQMessageSender
    {
        void SendMessage(BaseMessage baseMessage, string queueName);
    }
}
