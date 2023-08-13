namespace GamersEcommerce.Domain.Entities
{
    public class ProductStockQuantity
    {
        public int Id { get; set; }
        public int ProductQuantity { get; set; }
        public bool IsOutOfStock { get; set; }
        public int ProductId { get; set; }
    }
}
