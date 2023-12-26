using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Mvc;
using University.Bll.Services.Contracts;
using University.Bll.Dtos.Student;
using Microsoft.EntityFrameworkCore;

namespace University.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var students = await _studentService.GetAll(include: x => x.Include(x => x.Group!));

            return Ok(students);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var student = await _studentService.Get(id, include: x => x.Include(x => x.Group!));

            return Ok(student);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, StudentUpdateDto dto)
        {
            await _studentService.Update(id, dto);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Post(StudentCreateDto dto)
        {
            await _studentService.Add(dto);

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _studentService.Delete(id);

            return Ok();
        }
    }
}
