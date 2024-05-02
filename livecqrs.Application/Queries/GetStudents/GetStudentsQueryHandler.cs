using livecqrs.Domain.Interfaces;
using MediatR;

namespace livecqrs.Application.Queries.GetStudents
{
    public class GetStudentsQueryHandler : IRequestHandler<GetStudentsQuery, List<GetStudentsViewModel>>
    {
        private readonly IStudentRepository _studentRepository;
        public GetStudentsQueryHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public Task<List<GetStudentsViewModel>> Handle(GetStudentsQuery request, CancellationToken cancellationToken)
        {
            var students = _studentRepository.GetAll();

            var getStudentsViewModelList = students
                .Select(s => new GetStudentsViewModel(s.FullName))
                .ToList();

            return Task.FromResult(getStudentsViewModelList);
        }
    }
}
