namespace HealthcareAPI.DTOs
{
    public class DoctorDTO
    {
        public string? Name { get; set; }
        public string? Specialization { get; set; }
        public int Experience { get; set; }
        public decimal ConsultationFee { get; set; }
    }
}