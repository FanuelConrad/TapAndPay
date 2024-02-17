using Microsoft.AspNetCore.Mvc;
using TapAndPayWebApi.Business.Services;
using TapAndPayWebApi.Models;
using System.Threading.Tasks;

namespace TapAndPayWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentDataController : ControllerBase
    {
        private readonly IStudentDataService _studentDataService;

        public StudentDataController(IStudentDataService studentDataService)
        {
            _studentDataService = studentDataService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var studentData = await _studentDataService.GetAllStudentDataAsync();
            return Ok(studentData);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var studentData = await _studentDataService.GetStudentDataByIdAsync(id);
            if (studentData == null)
            {
                return NotFound();
            }
            return Ok(studentData);
        }

        [HttpPost]
        public async Task<IActionResult> Post(StudentData studentData)
        {
            await _studentDataService.AddStudentDataAsync(studentData);
            return CreatedAtAction(nameof(Get), new { id = studentData.AdmissionNumber }, studentData);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, StudentData studentData)
        {
            if (id != studentData.AdmissionNumber)
            {
                return BadRequest();
            }
            await _studentDataService.UpdateStudentDataAsync(studentData);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _studentDataService.DeleteStudentDataAsync(id);
            return NoContent();
        }
    }
}