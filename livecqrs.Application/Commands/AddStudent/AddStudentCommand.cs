

using MediatR;

namespace livecqrs.Application.Commands.AddStudent
{
    public class AddStudentCommand:IRequest<Unit>
    {
        public AddStudentCommand(string fullName, DateTime birthDate, int idUit)
        {
            FullName = fullName;
            BirthDate = birthDate;
            IdUnit = idUit;
        }

        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public int  IdUnit { get; set; }
    }
}
