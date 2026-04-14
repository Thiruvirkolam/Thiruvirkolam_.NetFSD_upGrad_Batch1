using HealthcareAPI.DTOs;
using HealthcareAPI.Models;
using HealthcareAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace HealthcareAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentsController : ControllerBase
    {
        private readonly AppointmentService _service;

        public AppointmentsController(AppointmentService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetAll());

        [HttpGet("patient/{id}")]
        public IActionResult GetByPatient(int id) =>
            Ok(_service.GetByPatient(id));

        [HttpPost]
        public IActionResult Book(AppointmentDTO dto)
        {
            var appt = new Appointment
            {
                PatientId = dto.PatientId,
                DoctorId = dto.DoctorId,
                AppointmentDate = dto.AppointmentDate
            };

            _service.Book(appt);
            return Ok(appt);
        }

        [HttpDelete("{id}")]
        public IActionResult Cancel(int id)
        {
            _service.Cancel(id);
            return NoContent();
        }
    }
}