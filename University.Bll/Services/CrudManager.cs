using AutoMapper;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using University.Bll.Dtos;
using University.Bll.Dtos.Student;
using University.Bll.Services.Contracts;
using University.Dal.DataContext.Entities;
using University.Dal.Repositories;
using University.Dal.Repositories.Contracts;

namespace University.Bll.Services
{
    public class CrudManager<TEntity, TDto, TCreateDto, TUpdateDto> : ICrudService<TEntity, TDto, TCreateDto, TUpdateDto>
        where TEntity : Entity
        where TDto : Dto
        where TCreateDto : Dto
        where TUpdateDto : Dto
    {
        private readonly IMapper _mapper;
        private readonly IRepository<TEntity> _repository;

        public CrudManager(IMapper mapper, IRepository<TEntity> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public virtual async Task Add(TCreateDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);

            await _repository.Add(entity);
        }

        public virtual async Task AddRange(List<TCreateDto> dtos)
        {
            var entities = _mapper.Map<IEnumerable<TEntity>>(dtos);

            await _repository.AddRange(entities);
        }

        public virtual async Task Delete(int id)
        {
            var existEntity = await _repository.Get(id);

            if (existEntity == null) throw new Exception($"Entity not found {id} id");

            await _repository.Delete(existEntity);
        }

        public virtual async Task<TDto> Get(int id, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, bool enableTracking = false)
        {
            var entity = await _repository.Get(id, include, enableTracking);

            if (entity == null) throw new Exception("Entity not found");

            var entityDto = _mapper.Map<TDto>(entity);

            return entityDto;
        }

        public virtual async Task<IEnumerable<TDto>> GetAll(Expression<Func<TEntity, bool>> predicate = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, bool enableTracking = false)
        {
            var entities = await _repository.GetAll(predicate, include, enableTracking);

            var dtos = _mapper.Map<IEnumerable<TDto>>(entities);

            return dtos;
        }

        public virtual async Task Update(int id, TUpdateDto dto)
        {
            var existEntity = await _repository.Get(id);

            if (existEntity == null) throw new Exception($"Entity not found with id");

            var updatedEntity = _mapper.Map<TEntity>(dto);
            updatedEntity.Id = id;

            await _repository.Update(updatedEntity);
        }
    }
}
