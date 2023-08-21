using GamersEcommerce.Domain.Entities;
using GamersEcommerce.Domain.Interfaces.Repositories;
using GamersEcommerce.Domain.Interfaces.Services;

namespace GamersEcommerce.Service.Services
{
    public class ProductService : IProductService
    {
        IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _repository.GetAsync();
        }
    }
}
