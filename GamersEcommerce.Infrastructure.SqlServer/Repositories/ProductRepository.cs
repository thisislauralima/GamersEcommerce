using GamersEcommerce.Domain.Entities;
using GamersEcommerce.Domain.Interfaces.Repositories;

namespace GamersEcommerce.Infrastructure.SqlServer.Repositories;

public class ProductRepository : BaseRepository<Product>, IProductRepository
{

    public ProductRepository(SqlServerDbContext sqlServerDbContext)
        : base(sqlServerDbContext)
    {
    }
}
