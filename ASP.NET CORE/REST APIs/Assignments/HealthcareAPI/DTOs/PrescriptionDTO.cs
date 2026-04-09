namespace HealthcareAPI.DTOs
{
    public class PrescriptionDTO
    {
        public int AppointmentId { get; set; }
        public string? Diagnosis { get; set; }
        public string? Medicines { get; set; }
        public string? Notes { get; set; }
    }
}