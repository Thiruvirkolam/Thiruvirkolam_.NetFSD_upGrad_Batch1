using Microsoft.AspNetCore.Mvc;

namespace PassengerService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PassengersController : ControllerBase
{
    private static List<object> passengers = new List<object>
    {
        new { passengerId = 201, name = "John Doe", age = 30 }
    };

    [HttpGet]
    public IActionResult GetPassengers()
    {
        return Ok(passengers);
    }

    [HttpPost]
    public IActionResult AddPassenger([FromBody] dynamic passenger)
    {
        passengers.Add(passenger);
        return Ok(passenger);
    }
}