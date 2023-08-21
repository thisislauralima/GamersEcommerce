using GamersEcommerce.Domain.Entities;

namespace GamersEcommerce.Domain.Application.UseCases
{
    public interface IProductCase
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
    }

}
