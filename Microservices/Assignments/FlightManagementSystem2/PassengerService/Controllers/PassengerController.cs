using Microsoft.AspNetCore.Mvc;
using PassengerService.DTOs;
using PassengerService.Services;

namespace PassengerService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PassengersController : ControllerBase
    {
        private readonly IPassengerService _service;

        public PassengersController(IPassengerService service)
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
            var result = _service.GetById(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post(PassengerDto dto)
        {
            return Ok(_service.Add(dto));
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, PassengerDto dto)
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