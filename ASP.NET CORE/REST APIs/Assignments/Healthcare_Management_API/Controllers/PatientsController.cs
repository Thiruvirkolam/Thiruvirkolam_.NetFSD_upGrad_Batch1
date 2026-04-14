using HealthcareAPI.Models;
using HealthcareAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace HealthcareAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientsController : ControllerBase
    {
        private readonly IPatientService _service;

        public PatientsController(IPatientService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetAll());

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var patient = _service.Get(id);
            if (patient == null) return NotFound();
            return Ok(patient);
        }

        [HttpPost]
        public IActionResult Create(Patient patient)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            _service.Create(patient);
            return Ok(patient);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Patient patient)
        {
            if (id != patient.PatientId) return BadRequest();
            _service.Update(patient);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return NoContent();
        }
    }
}