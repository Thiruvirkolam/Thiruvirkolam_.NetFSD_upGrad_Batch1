using FlightService.DTOs;
using FlightService.Services;
using Microsoft.AspNetCore.Mvc;

namespace FlightService.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class FlightsController : ControllerBase
    {
        private readonly IFlightService _service;

        public FlightsController(IFlightService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_service.GetById(id));
        }

        [HttpPost]
        public IActionResult Post(FlightDto dto)
        {
            return Ok(_service.Add(dto));
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, FlightDto dto)
        {
            var result = _service.Update(id, dto);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _service.Delete(id);
            if (!result) return NotFound();
            return Ok();
        }
    }
}
