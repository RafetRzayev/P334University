using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using University.Dal.DataContext.Entities;

namespace University.Dal.Repositories.Contracts;

public interface IRepository<TEntity> where TEntity : Entity
{
    Task<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>> predicate = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, bool enableTracking = false);
    Task<TEntity> Get(int id, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, bool enableTracking = false);
    //Task<TEntity> GetByCondition(Predicate<TEntity> predicate);
    Task Add(TEntity entity);
    Task AddRange(IEnumerable<TEntity> entities);
    Task Delete(TEntity entity);
    Task Update(TEntity entity);
}
