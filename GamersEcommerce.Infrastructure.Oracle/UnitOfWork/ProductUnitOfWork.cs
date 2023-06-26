using GamersEcommerce.Domain;
using GamersEcommerce.Domain.Interfaces;
namespace GamersEcommerce.Infrastructure.Oracle.UnitOfWork
{
    public class ProductUnitOfWork : IProductUnitOfWork
    {
        IBaseRepository _repository;

        public ProductUnitOfWork(IBaseRepository repository)
        {
            _repository = repository;
        }
        public void RegisterNewProductAsync(Product product)
        {
            try
            {
                _repository.RegisterNewProductAsync(product);
            }
            catch
            {
                throw;
            }
        }
    }
}
