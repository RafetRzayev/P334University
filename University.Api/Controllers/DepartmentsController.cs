using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using University.Bll.Dtos.Department;
using University.Bll.Services.Contracts;

namespace University.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentsController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var departments = await _departmentService.GetAll();

            return Ok(departments);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var department = await _departmentService.Get(id);

            return Ok(department);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, DepartmentUpdateDto dto)
        {
            await _departmentService.Update(id, dto);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Post(DepartmentCreateDto dto)
        {
            await _departmentService.Add(dto);

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _departmentService.Delete(id);

            return Ok();
        }
    }
}
