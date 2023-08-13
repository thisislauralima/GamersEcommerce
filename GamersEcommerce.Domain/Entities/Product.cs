namespace GamersEcommerce.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public DateTime ProductRegistrationDate { get; set; }
    }
}