using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using University.Bll.Dtos;
using University.Dal.DataContext.Entities;

namespace University.Bll.Services.Contracts;

public interface ICrudService<TEntity,TDto,TCreateDto,TUpdateDto> 
    where TEntity : Entity
    where TDto : Dto 
    where TCreateDto : Dto
    where TUpdateDto : Dto
{
    Task<IEnumerable<TDto>> GetAll(Expression<Func<TEntity, bool>> predicate = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, bool enableTracking = false);
    Task<TDto> Get(int id, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, bool enableTracking = false);
    Task Add(TCreateDto dto);
    Task AddRange(List<TCreateDto> dtos);
    Task Update(int id, TUpdateDto dto);
    Task Delete(int id);
}
