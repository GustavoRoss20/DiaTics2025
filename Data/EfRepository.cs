using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Data
{
    public class EfRepository : IEfRepository
    {
        readonly DiaTics2025Ctx _diaTics2025Ctx;
        private IDbContextTransaction? _transaction;

        public EfRepository(DiaTics2025Ctx diaTics2025Ctx)
        {
            _diaTics2025Ctx = diaTics2025Ctx;
        }

        public void BeginTransaction()
        {
            _transaction = _diaTics2025Ctx.Database.BeginTransaction();
        }

        public void CloseTransaction()
        {
            if (_transaction != null)
            {
                _transaction.Dispose();
                _transaction = null;
            }
        }

        public Task? CommitAsync()
        {
            if (_transaction != null)
            {
                return _transaction.CommitAsync();
            }
            else return null;
        }

        public void Remove<TEntity>(TEntity entity) where TEntity : class
        {
            if (_diaTics2025Ctx.Entry(entity).State == EntityState.Detached)
            {
                _diaTics2025Ctx.Set<TEntity>().Attach(entity);
            }
            _diaTics2025Ctx.Set<TEntity>().Remove(entity);
        }

        public TEntity? Find<TEntity, TId>(TId id) where TEntity : class
        {
            return _diaTics2025Ctx.Set<TEntity>().Find(id);
        }

        public IQueryable<TEntity> Queryanle<TEntity>() where TEntity : class
        {
            return _diaTics2025Ctx.Set<TEntity>().AsQueryable();
        }

        public Task? RollbackAsync()
        {
            if (_transaction != null)
            {
                return _transaction.RollbackAsync();
            }
            else return null;
        }

        public void Add<TEntity>(TEntity entity) where TEntity : class
        {
            _diaTics2025Ctx.Set<TEntity>().Add(entity);

        }

        public void Update<TEntity>(TEntity entity) where TEntity : class
        {
            _diaTics2025Ctx.Set<TEntity>().Attach(entity);
            _diaTics2025Ctx.Entry(entity).State = EntityState.Modified;
        }

        public Task SaveChangesAsync()
        {
            return _diaTics2025Ctx.SaveChangesAsync();
        }
    }
}
