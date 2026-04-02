using EntityAssignment2.Data;
using EntityAssignment2.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityAssignment2.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly ApplicationDbContext context;

        public CourseRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public List<Course> GetAll()
        {
            return context.Courses
                .Include(c => c.Enrollments)
                .ThenInclude(e => e.Student)
                .ToList();
        }

        public Course GetById(int id)
        {
            return context.Courses
                .Include(c => c.Enrollments)
                .ThenInclude(e => e.Student)
                .First(x => x.Id == id);
        }

        public void Add(Course c)
        {
            context.Courses.Add(c);
            context.SaveChanges();
        }

        public void Update(Course c)
        {
            context.Courses.Update(c);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var c = context.Courses.Find(id);
            if (c != null)
            {
                context.Courses.Remove(c);
                context.SaveChanges();
            }
        }
    }
}