using EntityAssignment2.Data;
using EntityAssignment2.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityAssignment2.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext context;

        public StudentRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public List<Student> GetAll()
        {
            return context.Students
                .Include(s => s.Enrollments)
                .ThenInclude(e => e.Course)
                .ToList();
        }

        public Student GetById(int id)
        {
            var student = context.Students
                .Include(s => s.Enrollments)
                .ThenInclude(e => e.Course)
                .FirstOrDefault(x => x.Id == id);
            if (student == null)
            {
                throw new KeyNotFoundException($"Student with id {id} not found");
            }
            return student;
        }

        public void Add(Student s)
        {
            context.Students.Add(s);
            context.SaveChanges();
        }

        public void Update(Student s)
        {
            context.Students.Update(s);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var s = context.Students.Find(id);
            if (s != null)
            {
                context.Students.Remove(s);
                context.SaveChanges();
            }
        }
    }
}