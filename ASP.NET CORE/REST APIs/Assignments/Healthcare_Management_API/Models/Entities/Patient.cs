using System.ComponentModel.DataAnnotations;

namespace HealthcareAPI.Models
{
    public class Patient
    {
        public int PatientId { get; set; }

        [Required, MaxLength(100)]
        public string? Name { get; set; }

        [Range(0, 120)]
        public int Age { get; set; }

        public string? Gender { get; set; }

        [Required]
        public string? ContactNumber { get; set; }

        public string? Address { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public ICollection<Appointment>? Appointments { get; set; }
    }
}