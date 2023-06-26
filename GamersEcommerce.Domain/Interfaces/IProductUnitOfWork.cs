namespace GamersEcommerce.Domain.Interfaces
{
    // duvida - pq essa interface fica na domain?
    public interface IProductUnitOfWork
    {
        void RegisterNewProductAsync(Product product);
    }
}
