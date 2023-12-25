using System.Linq.Expressions;
using University.Dal.DataContext.Entities;

namespace University.Dal.Repositories.Contracts;

public interface IRepository<TEntity> where TEntity : Entity
{
    Task<IEnumerable<TEntity>> GetAll();
    Task<TEntity> Get(int id);
    //Task<TEntity> GetByCondition(Predicate<TEntity> predicate);
    Task<TEntity> GetByCondition(Expression<Func<TEntity, bool>> predicate);
    Task Add(TEntity entity);
    Task AddRange(IEnumerable<TEntity> entities);
    Task Delete(TEntity entity);
    Task Update(TEntity entity);
}
