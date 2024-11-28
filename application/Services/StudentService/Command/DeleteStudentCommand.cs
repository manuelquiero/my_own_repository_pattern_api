using domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Services.StudentService.Command
{
    public record DeleteStudentCommand(int id) : IRequest<bool>;
    public class DeleteStudentCommandHandler : IRequestHandler<DeleteStudentCommand, bool>
    {
        private readonly IStudentRepository _repo;
        public DeleteStudentCommandHandler(IStudentRepository repo)
        {
            _repo = repo;
        }
        public async Task<bool> Handle(DeleteStudentCommand command, CancellationToken token)
        {
            return await _repo.Delete(command.id);
        }
    }
}
