using Microsoft.AspNetCore.Mvc;
using FlightAPI.Models;
using FlightAPI.Repositories;

namespace FlightAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FlightController : ControllerBase
    {
        private readonly FlightRepository _repo;

        public FlightController()
        {
            _repo = new FlightRepository();
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_repo.GetAllFlights());
        }

        [HttpGet("Get/{id}")]
        public IActionResult Get(int id)
        {
            var flight = _repo.GetFlight(id);
            if (flight == null) return NotFound();
            return Ok(flight);
        }

        [HttpPost("Add")]
        public IActionResult Add([FromBody] Flight flight)
        {
            _repo.AddFlight(flight);
            return Ok(flight);
        }

        [HttpPut("Edit")]
        public IActionResult Edit([FromBody] Flight flight)
        {
            _repo.EditFlight(flight);
            return Ok(flight);
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            _repo.DeleteFlight(id);
            return Ok();
        }
    }
}