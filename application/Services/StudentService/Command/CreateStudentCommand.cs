using domain.Interfaces;
using domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Services.StudentService.Command
{
    public class CreateStudentCommand(Student student) : IRequest<Student>
    {
        public Student CreateStudent { get; set; } = student;
    }
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, Student>
    {
        private readonly IStudentRepository _repo;
        public CreateStudentCommandHandler(IStudentRepository repo)
        {
            _repo = repo;
        }
        public async Task<Student> Handle(CreateStudentCommand command, CancellationToken token)
        {
            return await _repo.Create(command.CreateStudent);
        }
    }
}
