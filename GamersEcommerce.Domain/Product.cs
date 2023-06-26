using GamersEcommerce.Infrastructure.RabbitMq;

namespace GamersEcommerce.Domain
{
    public class Product : BaseMessage
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}