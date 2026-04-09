using HealthcareAPI.DTOs;
using HealthcareAPI.Models;
using HealthcareAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace HealthcareAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PrescriptionsController : ControllerBase
    {
        private readonly PrescriptionService _service;

        public PrescriptionsController(PrescriptionService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Add(PrescriptionDTO dto)
        {
            var p = new Prescription
            {
                AppointmentId = dto.AppointmentId,
                Diagnosis = dto.Diagnosis,
                Medicines = dto.Medicines,
                Notes = dto.Notes
            };

            _service.Add(p);
            return Ok(p);
        }

        [HttpGet("{appointmentId}")]
        public IActionResult Get(int appointmentId) =>
            Ok(_service.GetByAppointment(appointmentId));
    }
}