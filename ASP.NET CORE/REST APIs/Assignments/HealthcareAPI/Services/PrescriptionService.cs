using HealthcareAPI.Models;
using HealthcareAPI.Data;

namespace HealthcareAPI.Services
{
    public class PrescriptionService
    {
        private readonly AppDbContext _context;

        public PrescriptionService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Prescription p)
        {
            _context.Prescriptions.Add(p);
            _context.SaveChanges();
        }

        public Prescription? GetByAppointment(int id) =>
            _context.Prescriptions.FirstOrDefault(p => p.AppointmentId == id);
    }
}