using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using University.Dal.DataContext;
using University.Dal.DataContext.Entities;
using University.Dal.Repositories.Contracts;

namespace University.Dal.Repositories;

public class EfCoreRepository<TEntity> : IRepository<TEntity> where TEntity : Entity
{
    private readonly AppDbContext _dbContext;

    public EfCoreRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public virtual async Task Add(TEntity entity)
    {
        await _dbContext.Set<TEntity>().AddAsync(entity);  
        
        await _dbContext.SaveChangesAsync();
    }

    public virtual async Task AddRange(IEnumerable<TEntity> entities)
    {
        await _dbContext.Set<TEntity>().AddRangeAsync(entities);

        await _dbContext.SaveChangesAsync();
    }

    public virtual async Task Delete(TEntity entity)
    {
        _dbContext.Set<TEntity>().Remove(entity);

        await _dbContext.SaveChangesAsync();
    }

    public virtual async Task<TEntity> Get(int id)
    {
        var result = await _dbContext.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);

        return result;
    }

    public virtual async Task<IEnumerable<TEntity>> GetAll()
    {
        var result = await _dbContext.Set<TEntity>().AsNoTracking().ToListAsync();

        return result;
    }

    public virtual async Task<TEntity> GetByCondition(Expression<Func<TEntity, bool>> predicate)
    {
        var result = await _dbContext.Set<TEntity>().FirstOrDefaultAsync(predicate);

        return result;
    }

    public virtual async Task Update(TEntity entity)
    {
        _dbContext.Set<TEntity>().Update(entity);

        await _dbContext.SaveChangesAsync();
    }
}
