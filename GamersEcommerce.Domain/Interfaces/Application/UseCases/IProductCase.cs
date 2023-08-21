using GamersEcommerce.Domain.Entities;

namespace GamersEcommerce.Domain.Interfaces.Application.UseCases
{
    public interface IProductCase
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
    }
}
