using Ecommerce.Infrastructure.Oracle;
using GamersEcommerce.Domain;
using GamersEcommerce.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Net;

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

        //public Task<Product> RegisterNewProductAsync(Product product)
        //{
        //    var dbproduct = _context.Products.Find(product.Id);
        //    return dbproduct ?? dbproduct;
        //}
    }
}