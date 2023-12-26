using University.Bll.Dtos.Department;
using University.Dal.DataContext.Entities;

namespace University.Bll.Services.Contracts
{
    public interface IDepartmentService : ICrudService<Department, DepartmentDto, DepartmentCreateDto, DepartmentUpdateDto>
    {
       
    }
}
