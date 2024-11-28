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
    public record UpdateStudentCommand(Student student) : IRequest<Student>;
    
    public class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommand, Student>
    {
        private readonly IStudentRepository _repo;
        public UpdateStudentCommandHandler(IStudentRepository repo)
        {
            _repo = repo;
        }
        public async Task<Student> Handle(UpdateStudentCommand command, CancellationToken token)
        {
            return await _repo.Update(command.student);
        }
    }
}
