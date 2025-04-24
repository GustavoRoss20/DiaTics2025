namespace Data
{
    public interface IEfRepository
    {
        void BeginTransaction();
        Task? CommitAsync();
        Task? RollbackAsync();
        void CloseTransaction();
        IQueryable<TEntity> Queryanle<TEntity>() where TEntity : class;
        TEntity? Find<TEntity, TId>(TId id) where TEntity : class;
        void Add<TEntity>(TEntity entity) where TEntity : class;
        void Update<TEntity>(TEntity entity) where TEntity : class;
        void Remove<TEntity>(TEntity entity) where TEntity : class;
        Task SaveChangesAsync();
    }
}
