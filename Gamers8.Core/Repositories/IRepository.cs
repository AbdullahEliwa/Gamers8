using System.Linq.Expressions;

namespace Gamers8.Core.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        #region Read Operations 
        Task<TEntity> Get(int id);
        Task<IEnumerable<TEntity>> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> FirstOrDefault(Expression<Func<TEntity, bool>> predicate);
        #endregion

        #region Create Operations
        Task Add(TEntity entity);

        Task AddRange(IEnumerable<TEntity> entities);
        #endregion

        #region Delete Operations
        void Delete(TEntity entity);

        void DeleteRange(IEnumerable<TEntity> entities);
        #endregion
    }
}
