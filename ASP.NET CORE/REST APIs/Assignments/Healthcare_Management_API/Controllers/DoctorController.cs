using HealthcareAPI.DTOs;
using HealthcareAPI.Models;
using HealthcareAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace HealthcareAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DoctorsController : ControllerBase
    {
        private readonly DoctorService _service;

        public DoctorsController(DoctorService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetAll());

        [HttpGet("specialization")]
        public IActionResult GetBySpec(string spec) =>
            Ok(_service.GetBySpec(spec));

        [HttpPost]
        public IActionResult Create(DoctorDTO dto)
        {
            var doctor = new Doctor
            {
                Name = dto.Name,
                Specialization = dto.Specialization,
                Experience = dto.Experience,
                ConsultationFee = dto.ConsultationFee
            };

            _service.Add(doctor);
            return Ok(doctor);
        }
    }
}