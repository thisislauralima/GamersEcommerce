using GamersEcommerce.Domain;
using GamersEcommerce.Domain.Interfaces;

namespace GamersEcommerce.Application
{

    // essa camada é para as lógicas de negócio e implementações
    // para implementar essas lógicas ela utiliza use cases
    // use case é um requerimento funcional obrigatório para a aplicação
    public class ProductCase : IProductCase
    {
        IBaseRepository _repository;

        public ProductCase(IBaseRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            try
            {
                return await _repository.GetAllProductsAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}