using application.Services.StudentService.Command;
using application.Services.StudentService.Query;
using domain.Models;
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

        [HttpGet("get-student-by-id")]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var student = await _mediatr.Send(new GetStudentQuery(id));
            return Ok(student);
        }

        [HttpPost("add-student")]
        public async Task<IActionResult> CreateStudent(Student student)
        {
            var result = await _mediatr.Send(new CreateStudentCommand(student));
            if (result is null)
                return BadRequest("Something went wrong. Please give up and stop bothering me, ok?");

            return Ok(result);
        }

        [HttpPut("update-student")]
        public async Task<IActionResult> UpdateStudent(Student student)
        {
            var result = await _mediatr.Send(new UpdateStudentCommand(student));
            if (result is null)
                return BadRequest("I can't change the student information. Bleehh :P");

            return Ok(result);
        }

        [HttpDelete("delete-student")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var result = await _mediatr.Send(new DeleteStudentCommand(id)); 
            if(!result)
                return BadRequest("Can't delete right now.");

            return Ok("Student record deleted.");
        }
    }
}
