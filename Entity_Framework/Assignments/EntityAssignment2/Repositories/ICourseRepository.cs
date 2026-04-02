using EntityAssignment2.Models;

namespace EntityAssignment2.Repositories
{
    public interface ICourseRepository
    {
        List<Course> GetAll();
        Course GetById(int id);
        void Add(Course c);
        void Update(Course c);
        void Delete(int id);
    }
}