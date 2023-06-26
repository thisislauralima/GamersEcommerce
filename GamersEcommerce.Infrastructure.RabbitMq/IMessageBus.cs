namespace GamersEcommerce.Infrastructure.RabbitMq
{
    public interface IMessageBus
    {
        Task PublicMessage(BaseMessage message, string queueName);
    }
}
