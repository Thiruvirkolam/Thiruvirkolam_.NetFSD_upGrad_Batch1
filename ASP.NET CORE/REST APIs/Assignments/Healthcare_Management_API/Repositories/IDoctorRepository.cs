using HealthcareAPI.Models;

namespace HealthcareAPI.Repositories
{
    public interface IDoctorRepository
    {
        IEnumerable<Doctor> GetAll();
        IEnumerable<Doctor> GetBySpecialization(string spec);
        void Add(Doctor doctor);
        void Save();
    }
}