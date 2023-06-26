namespace GamersEcommerce.Domain.Interfaces
{
    public interface IBaseRepository
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Product RegisterNewProductAsync(Product product);
    }
}
