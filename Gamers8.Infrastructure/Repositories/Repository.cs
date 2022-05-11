using Booking.Infrastructure.Persistence;
using Gamers8.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Gamers8.Infrastructure.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly Gamers8Context _context;
        private readonly DbSet<TEntity> _entities;
        public Repository(Gamers8Context context)
        {
            this._context = context;
            _entities = _context.Set<TEntity>();
        }


        #region Read Operations
        public async Task<TEntity> Get(int id)
        {
            return await _entities.FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _entities.ToListAsync();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _entities.Where(predicate);
        }

        public async Task<TEntity> FirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return await _entities.FirstOrDefaultAsync(predicate);
        }
        #endregion

        #region Create Operations
        public async Task Add(TEntity entity)
        {
            await _entities.AddAsync(entity);
        }

        public async Task AddRange(IEnumerable<TEntity> entities)
        {
            await _entities.AddRangeAsync(entities);
        }
        #endregion

        #region Delete Operations
        public void Delete(TEntity entity)
        {
            _entities.Remove(entity);
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            _entities.RemoveRange(entities);
        }
        #endregion
    }
}
