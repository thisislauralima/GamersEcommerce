using Ecommerce.Infrastructure.Oracle;
using GamersEcommerce.Domain;
using GamersEcommerce.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GamersEcommerce.Infrastructure.Oracle.Repositories
{
    public class BaseRepository : IBaseRepository
    {
        OracleDbContext _context { get; set; }
        // DbSet - usado para fazer as queries para uma dada entidade
        DbSet<Product> _dbset;

        public BaseRepository(OracleDbContext context)
        {
            _context = context;
            // dá acesso às entidades
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }
    }
}