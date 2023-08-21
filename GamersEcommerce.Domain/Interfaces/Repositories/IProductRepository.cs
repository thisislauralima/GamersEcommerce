using GamersEcommerce.Domain.Entities;

namespace GamersEcommerce.Domain.Interfaces.Repositories
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        //Task<IEnumerable<Product>> GetAllProductsAsync();
    }
}
