using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using University.Bll.Services.Contracts;
using University.Bll.ViewModels.Student;

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

        [HttpPost]
        public async Task<IActionResult> Post(StudentCreateDto dto)
        {
            await _studentService.AddStudent(dto);

            return Ok();
        }
    }
}
