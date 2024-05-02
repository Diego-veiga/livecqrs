
using livecqrs.Domain.Entities;

namespace livecqrs.Domain.Interfaces
{
    public class StudentRepository
    {
        public void Add(Student student)
        {

        }

        public List<Student> GetAll()
        {
            return new List<Student>
            {
                new Student("luis", DateTime.Now)
            };
        }
    }
}
