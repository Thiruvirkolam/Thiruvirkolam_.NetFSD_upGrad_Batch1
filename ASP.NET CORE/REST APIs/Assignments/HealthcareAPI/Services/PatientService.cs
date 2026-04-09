using HealthcareAPI.Models;
using HealthcareAPI.Repositories;

namespace HealthcareAPI.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _repo;

        public PatientService(IPatientRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Patient> GetAll() => _repo.GetAll();

        public Patient Get(int id) => _repo.GetById(id);

        public void Create(Patient patient)
        {
            _repo.Add(patient);
            _repo.Save();
        }

        public void Update(Patient patient)
        {
            _repo.Update(patient);
            _repo.Save();
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
            _repo.Save();
        }
    }
}