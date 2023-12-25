using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Bll.Services.Contracts;
using University.Bll.ViewModels.Student;
using University.Dal.DataContext.Entities;
using University.Dal.Repositories.Contracts;

namespace University.Bll.Services
{
    public class StudentManager : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentManager(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task AddStudent(StudentCreateDto studentCreateDto)
        {
            var student = new Student
            {
                Name = studentCreateDto.Name,
                Age = studentCreateDto.Age,
                GroupId = studentCreateDto.GroudId
            };

            await _studentRepository.Add(student);
        }

        public Task AddStudents(List<StudentCreateDto> studentCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<StudentDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<StudentDto> GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateStudent(StudentUpdateDto studentUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
