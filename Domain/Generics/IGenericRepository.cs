using System.Linq.Expressions;

namespace API_CHASKAS.Domain.Generics
{
    public interface  IGenericRepository<TEntity> where TEntity : class
    {
        Task<List<TEntity>> GetAll();
        
        Task<List<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);
        
        Task<TEntity> GetById(object id);
        
        Task Add(TEntity entity);
        
        Task AddRange(IEnumerable<TEntity> entities);
        
        Task Remove(TEntity entity);
        
        Task RemoveRange(IEnumerable<TEntity> entities);
    }
}