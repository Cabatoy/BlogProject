using BlogSolution.Shared.Entities.Abstract;
using System.Linq.Expressions;

namespace BlogSolution.Shared.Data.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity,new ()
    {
        Task<T> GetAsycn(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties); //var Kullanici=repositroy.GetAsync(k=> k.Id=15)

        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties);

        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate);

    }
}
