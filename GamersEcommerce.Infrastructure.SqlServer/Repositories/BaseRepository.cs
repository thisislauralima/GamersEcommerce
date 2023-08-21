using GamersEcommerce.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GamersEcommerce.Infrastructure.SqlServer.Repositories

{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public readonly SqlServerDbContext _context;
        // DbSet - usado para fazer as queries para uma dada entidade
        DbSet<T> _dbset;

        public BaseRepository(SqlServerDbContext context)
        {
            // dá acesso às entidades
            _context = context;
        }
        
        public async Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate is not null)
            {
                return _dbset.Where(predicate);
            }
            return await _dbset.ToListAsync();
        }
    }
}