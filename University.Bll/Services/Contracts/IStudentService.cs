using University.Bll.ViewModels.Student;

namespace University.Bll.Services.Contracts
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentDto>> GetAll();
        Task<StudentDto> GetStudent(int id);
        Task AddStudent(StudentCreateDto studentCreateDto);
        Task AddStudents(List<StudentCreateDto> studentCreateDto);
        Task UpdateStudent(StudentUpdateDto studentUpdateDto);
        Task DeleteStudent(int id);
    }
}
