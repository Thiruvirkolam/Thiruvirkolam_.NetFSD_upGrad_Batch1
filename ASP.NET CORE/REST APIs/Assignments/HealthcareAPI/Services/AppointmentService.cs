using HealthcareAPI.Models;
using HealthcareAPI.Repositories;
using HealthcareAPI.Data;

namespace HealthcareAPI.Services
{
    public class AppointmentService
    {
        private readonly AppointmentRepository _repo;
        private readonly AppDbContext _context;

        public AppointmentService(AppointmentRepository repo, AppDbContext context)
        {
            _repo = repo;
            _context = context;
        }

        public IEnumerable<Appointment> GetAll() => _repo.GetAll();

        public IEnumerable<Appointment> GetByPatient(int id) => _repo.GetByPatient(id);

        public void Book(Appointment a)
        {
            if (!_context.Patients.Any(p => p.PatientId == a.PatientId) ||
                !_context.Doctors.Any(d => d.DoctorId == a.DoctorId))
                throw new Exception("Invalid Patient or Doctor");

            _repo.Add(a);
            _repo.Save();
        }

        public void Cancel(int id)
        {
            var appt = _context.Appointments.Find(id);
            if (appt != null)
            {
                appt.Status = AppointmentStatus.Cancelled;
                _context.SaveChanges();
            }
        }
    }
}