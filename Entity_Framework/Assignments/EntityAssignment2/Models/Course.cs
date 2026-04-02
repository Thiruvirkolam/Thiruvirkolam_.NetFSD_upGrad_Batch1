using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityAssignment2.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        [Range(1, 10)]
        public int Credits { get; set; }

        public List<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}