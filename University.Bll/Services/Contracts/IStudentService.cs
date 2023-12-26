using University.Bll.Dtos.Student;
using University.Dal.DataContext.Entities;

namespace University.Bll.Services.Contracts
{
    public interface IStudentService1 
    {
        Task<IEnumerable<StudentDto>> GetStudents();
        Task<StudentDto> GetStudent(int id);
        Task AddStudent(StudentCreateDto studentCreateDto);
        Task AddStudents(List<StudentCreateDto> studentCreateDto);
        Task UpdateStudent(int id, StudentUpdateDto studentUpdateDto);
        Task DeleteStudent(int id);
    }

    public interface IStudentService : ICrudService<Student, StudentDto, StudentCreateDto, StudentUpdateDto>
    {
       
    }    
}
