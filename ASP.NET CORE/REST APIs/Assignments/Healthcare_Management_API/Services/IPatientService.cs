using HealthcareAPI.Models;

namespace HealthcareAPI.Services
{
    public interface IPatientService
    {
        IEnumerable<Patient> GetAll();
        Patient Get(int id);
        void Create(Patient patient);
        void Update(Patient patient);
        void Delete(int id);
    }
}