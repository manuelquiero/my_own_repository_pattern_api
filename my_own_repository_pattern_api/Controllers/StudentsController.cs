using application.Services.StudentService.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace my_own_repository_pattern_api.Controllers
{
    [Route("api")]
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly IMediator _mediatr;
        public StudentsController(IMediator mediatr) 
        { 
            _mediatr = mediatr;
        }
        [HttpGet("get-all-students")]
        public async Task<IActionResult> GetAllStudents()
        {
            var students = await _mediatr.Send(new GetAllStudentQuery());
            return Ok(students);
        }
    }
}
