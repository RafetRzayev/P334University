using AutoMapper;
using University.Bll.Dtos.Department;
using University.Bll.Dtos.Student;
using University.Dal.DataContext.Entities;

namespace University.Bll.AutoMapping;

public class Profiles : Profile
{
    public Profiles()
    {
        CreateMap<Student, StudentDto>().ForMember(x => x.GroupName, y => y.MapFrom(x => x.Group == null ? "" : x.Group.Name)).ReverseMap();
        CreateMap<StudentCreateDto, Student>();
        CreateMap<StudentUpdateDto, Student>();

        CreateMap<Department, DepartmentDto>().ReverseMap();
        CreateMap<DepartmentCreateDto, Department>();
        CreateMap<DepartmentUpdateDto, Department>();
    }
}
