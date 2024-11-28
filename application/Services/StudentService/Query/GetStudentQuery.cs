using domain.Interfaces;
using domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Services.StudentService.Query
{
    public record GetStudentQuery(int id) : IRequest<Student>;
    public class GetStudentQueryHandler : IRequestHandler<GetStudentQuery, Student>
    {
        private readonly IStudentRepository _repo;
        public GetStudentQueryHandler(IStudentRepository repo)
        {
            _repo = repo;
        }
        public async Task<Student> Handle(GetStudentQuery request, CancellationToken token)
        {
            return await _repo.Get(request.id);
        }
    }
}
