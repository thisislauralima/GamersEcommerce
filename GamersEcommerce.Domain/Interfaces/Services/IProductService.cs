using GamersEcommerce.Domain.Entities;

namespace GamersEcommerce.Domain.Interfaces.Services
{
    public interface IProductService
    {
        public Task<IEnumerable<Product>> GetAllProductsAsync();
    }
}