using HealthcareAPI.Data;
using HealthcareAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthcareAPI.Repositories
{
    public class AppointmentRepository
    {
        private readonly AppDbContext _context;

        public AppointmentRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Appointment> GetAll() =>
            _context.Appointments.Include(a => a.Patient).Include(a => a.Doctor).ToList();

        public IEnumerable<Appointment> GetByPatient(int id) =>
            _context.Appointments.Where(a => a.PatientId == id).ToList();

        public void Add(Appointment a) => _context.Appointments.Add(a);

        public void Save() => _context.SaveChanges();
    }
}