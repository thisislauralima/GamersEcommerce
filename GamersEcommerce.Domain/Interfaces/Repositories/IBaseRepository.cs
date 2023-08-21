using System.Linq.Expressions;

namespace GamersEcommerce.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T>
    {
        Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> predicate = null);
    }
}
