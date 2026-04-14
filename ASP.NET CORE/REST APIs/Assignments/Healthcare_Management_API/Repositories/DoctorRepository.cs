using HealthcareAPI.Data;
using HealthcareAPI.Models;

namespace HealthcareAPI.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly AppDbContext _context;

        public DoctorRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Doctor> GetAll() => _context.Doctors.ToList();

        public IEnumerable<Doctor> GetBySpecialization(string spec) =>
            _context.Doctors.Where(d => d.Specialization == spec).ToList();

        public void Add(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
        }

        public void Save() => _context.SaveChanges();
    }
}