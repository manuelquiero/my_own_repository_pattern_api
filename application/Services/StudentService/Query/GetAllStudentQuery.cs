using domain.Interfaces;
using domain.Models;
using MediatR;

namespace application.Services.StudentService.Query
{
    public record GetAllStudentQuery : IRequest<List<Student>>;
    public class GetAllStudentQueryHandler : IRequestHandler<GetAllStudentQuery, List<Student>>
    {
        private readonly IStudentRepository _repository;
        public GetAllStudentQueryHandler(IStudentRepository repo)
        {
            _repository = repo;
        }

        public async Task<List<Student>> Handle(GetAllStudentQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAll();
        }
    }
}
