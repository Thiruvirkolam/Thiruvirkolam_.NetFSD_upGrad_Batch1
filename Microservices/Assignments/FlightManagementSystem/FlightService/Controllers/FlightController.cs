using Microsoft.AspNetCore.Mvc;

namespace FlightService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FlightsController : ControllerBase
{
    private static List<object> flights = new List<object>
    {
        new { id = 1, flightNumber = "AI101", source = "Hyderabad", destination = "Delhi" }
    };

    [HttpGet]
    public IActionResult GetFlights()
    {
        return Ok(flights);
    }

    [HttpGet("{id}")]
    public IActionResult GetFlight(int id)
    {
        var flight = flights.FirstOrDefault(f => (int)f.GetType().GetProperty("id").GetValue(f) == id);
        return Ok(flight);
    }

    [HttpPost]
    public IActionResult AddFlight([FromBody] dynamic flight)
    {
        flights.Add(flight);
        return Ok(flight);
    }
}