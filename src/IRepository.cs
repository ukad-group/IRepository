using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetAllAsNoTracking();
        Task<int> CountAsync(IQueryable<TEntity> source, CancellationToken ct);
        TEntity GetById(int id);
        Task<TEntity> GetByIdAsync(int id, CancellationToken ct = default);
        Task<TSource> FirstOrDefaultAsync<TSource>(IQueryable<TSource> source, CancellationToken ct = default);
        Task<IList<TSource>> ToListAsync<TSource>(IQueryable<TSource> source, CancellationToken ct = default);
        void Add(TEntity entity);
        Task AddAsync(TEntity entity, CancellationToken ct = default);
        void AddRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void Update(IEnumerable<TEntity> entities);
        void Delete(TEntity entity);
        void Delete(int id);
        void SaveChanges();
        Task SaveChangesAsync(CancellationToken ct = default);
        IQueryable<TEntity> Include<TProperty>(Expression<Func<TEntity, TProperty>> xFunc);
        IQueryable<TEntity> Include<TProperty>(IQueryable<TEntity> querable, Expression<Func<TEntity, TProperty>> xFunc);
    }
}
