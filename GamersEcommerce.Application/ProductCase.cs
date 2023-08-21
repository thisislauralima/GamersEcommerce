using GamersEcommerce.Domain.Application.UseCases;
using GamersEcommerce.Domain.Entities;
using GamersEcommerce.Domain.Interfaces.Services;

namespace GamersEcommerce.Application
{
    // use case é um requerimento funcional obrigatório para a aplicação
    public class ProductCase : IProductCase
    {
        IProductService _productService;

        public ProductCase(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            try
            {
                return await _productService.GetAllProductsAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}