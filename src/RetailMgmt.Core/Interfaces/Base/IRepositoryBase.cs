using RetailMgmt.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RetailMgmt.Core.Interfaces.Base
{
    public interface IRepositoryBase<T> where T : EntityBase
    {

        #region Insert
        Task<T> AddAsync(T entity);
        void Add(T entity);

        Task AddRangeAsync(IEnumerable<T> entities);

        void AddRange(IEnumerable<T> entities);

        #endregion

        #region Update
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);
        #endregion

        #region Delete
        void RemoveRange(IEnumerable<T> entities);
        void Remove(T entity);
        #endregion

        #region Aggregate
        int Count(Expression<Func<T, bool>> predicate);

        Task<int> CountAsync(Expression<Func<T, bool>> predicate);

        bool Any(Expression<Func<T, bool>> predicate);

        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);

        #endregion

        #region Select
        IQueryable<T> GetQueryables(Expression<Func<T, bool>> predicate);
        Task<IReadOnlyList<T>> GetAllAsync();

        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate);
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
                                Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                string includeString = null,
                                bool disableTracking = true);
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
                                        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                        List<Expression<Func<T, object>>> includes = null,
                                        bool disableTracking = true);
        Task<T> GetByIdAsync(object id);
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
        T FirstOrDefault(Expression<Func<T, bool>> predicate);
        Task<T> SingleAsync(Expression<Func<T, bool>> predicate);
        Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate);
        #endregion

        #region SaveChanges
        void SaveChanges();

        Task SaveChangesAsync();
        #endregion

        #region Dispose
        void Dispose();

        Task DisposeAsync();

        #endregion
    }
}
