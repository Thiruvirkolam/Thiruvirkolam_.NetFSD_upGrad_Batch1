using HealthcareAPI.Data;
using HealthcareAPI.Models;

namespace HealthcareAPI.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly AppDbContext _context;

        public PatientRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Patient> GetAll() => _context.Patients.ToList();

        public Patient? GetById(int id) => _context.Patients.Find(id);

        public void Add(Patient patient)
        {
            _context.Patients.Add(patient);
        }

        public void Update(Patient patient)
        {
            _context.Patients.Update(patient);
        }

        public void Delete(int id)
        {
            var patient = GetById(id);
            if (patient != null) _context.Patients.Remove(patient);
        }

        public void Save() => _context.SaveChanges();
    }
}