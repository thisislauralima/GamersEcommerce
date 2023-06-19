namespace GamersEcommerce.Domain.Interfaces
{
    public interface IProductCase
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
    }

}
