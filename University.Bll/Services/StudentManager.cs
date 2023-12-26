using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Bll.Services.Contracts;
using University.Bll.Dtos.Student;
using University.Dal.DataContext.Entities;
using University.Dal.Repositories.Contracts;

namespace University.Bll.Services
{
    public class StudentManager1 : IStudentService1
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public StudentManager1(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }     
        public async Task AddStudent(StudentCreateDto studentCreateDto)
        {
            var student = _mapper.Map<Student>(studentCreateDto);

            await _studentRepository.Add(student);
        }

        public Task AddStudents(List<StudentCreateDto> studentCreateDto)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteStudent(int id)
        {
            var existStudent = await _studentRepository.Get(id);

            if (existStudent == null) throw new Exception($"Student not found {id} id");

            await _studentRepository.Delete(existStudent);
        }

        public async Task<IEnumerable<StudentDto>> GetStudents()
        {
            var students = await _studentRepository.GetAll();

            var studentDtos = new List<StudentDto>();

            foreach (var student in students)
            {
                studentDtos.Add(_mapper.Map<StudentDto>(student));
            }

            return studentDtos;
        }

        public async Task<StudentDto> GetStudent(int id)
        {
            var student = await _studentRepository.Get(id);

            if (student == null) throw new Exception("Student not found");

            var studentDto = _mapper.Map<StudentDto>(student);

            return studentDto;
        }

        public async Task UpdateStudent(int id, StudentUpdateDto studentUpdateDto)
        {
            var existStudent = await _studentRepository.Get(id);

            if (existStudent == null) throw new Exception($"Student not found with {id} id");

            var updatedStudent = _mapper.Map<Student>(studentUpdateDto);
            updatedStudent.Id = id;

            await  _studentRepository.Update(updatedStudent);
        }
    }

    public class StudentManager : CrudManager<Student, StudentDto, StudentCreateDto, StudentUpdateDto>, IStudentService
    {
        public StudentManager(IMapper mapper, IRepository<Student> repository) : base(mapper, repository)
        {
        }
    }
}
