using AutoMapper;
using University.Bll.Services.Contracts;
using University.Dal.DataContext.Entities;
using University.Dal.Repositories.Contracts;
using University.Bll.Dtos.Department;

namespace University.Bll.Services
{
    public class DepartmentManager : CrudManager<Department, DepartmentDto, DepartmentCreateDto, DepartmentUpdateDto>, IDepartmentService
    {
        public DepartmentManager(IMapper mapper, IRepository<Department> repository) : base(mapper, repository)
        {
        }
    }
}
