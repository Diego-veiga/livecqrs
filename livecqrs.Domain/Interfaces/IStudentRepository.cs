
using livecqrs.Domain.Entities;

namespace livecqrs.Domain.Interfaces
{
    public interface IStudentRepository
    {
        void Add(Student student);
        List<Student> GetAll();
    }
}
