using EntityAssignment2.Models;

namespace EntityAssignment2.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
        Student GetById(int id);
        void Add(Student s);
        void Update(Student s);
        void Delete(int id);
    }
}