using HealthcareAPI.Models;
using HealthcareAPI.Repositories;

namespace HealthcareAPI.Services
{
    public class DoctorService
    {
        private readonly IDoctorRepository _repo;

        public DoctorService(IDoctorRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Doctor> GetAll() => _repo.GetAll();

        public IEnumerable<Doctor> GetBySpec(string spec) => _repo.GetBySpecialization(spec);

        public void Add(Doctor doctor)
        {
            _repo.Add(doctor);
            _repo.Save();
        }
    }
}