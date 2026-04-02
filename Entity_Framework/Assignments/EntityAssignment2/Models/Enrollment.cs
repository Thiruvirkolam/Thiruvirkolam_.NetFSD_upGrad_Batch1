using System.ComponentModel.DataAnnotations;

namespace EntityAssignment2.Models
{
    public class Enrollment
    {
        public int Id { get; set; }

        [Required]
        public int StudentId { get; set; }

        public Student? Student { get; set; }

        [Required]
        public int CourseId { get; set; }

        public Course? Course { get; set; }

        public string? Grade { get; set; }
    }
}