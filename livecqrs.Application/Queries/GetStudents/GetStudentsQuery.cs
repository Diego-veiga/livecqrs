
using MediatR;

namespace livecqrs.Application.Queries.GetStudents
{
    public class GetStudentsQuery : IRequest<List<GetStudentsViewModel>>
    {
    }
}
