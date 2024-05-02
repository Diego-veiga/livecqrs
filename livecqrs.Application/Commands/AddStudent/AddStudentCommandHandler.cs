using livecqrs.Domain.Entities;
using livecqrs.Domain.Interfaces;
using MediatR;


namespace livecqrs.Application.Commands.AddStudent
{
    public class AddStudentCommandHandler : IRequestHandler<AddStudentCommand, Unit>
    {
        private readonly IStudentRepository _studentRepository;
        public AddStudentCommandHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public Task<Unit> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            var student = new Student(request.FullName, request.BirthDate);

            _studentRepository.Add(student);

            return Task.FromResult(Unit.Value);
        }
    }
}
