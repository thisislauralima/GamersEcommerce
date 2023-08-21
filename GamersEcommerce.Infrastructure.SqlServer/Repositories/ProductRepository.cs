using GamersEcommerce.Domain.Entities;
using GamersEcommerce.Domain.Interfaces.Repositories;

namespace GamersEcommerce.Infrastructure.SqlServer.Repositories;

public class ProductRepository : BaseRepository<Product>, IProductRepository
{
    IProductRepository _productRepository;

    public ProductRepository(SqlServerDbContext sqlServerDbContext, IProductRepository productRepository)
        : base(sqlServerDbContext)
    {
        _productRepository = productRepository;
    }

    public Task<IEnumerable<Product>> GetAsync()
    {
        return _productRepository.GetAsync();
    }
}
