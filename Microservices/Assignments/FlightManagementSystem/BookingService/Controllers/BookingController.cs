using Microsoft.AspNetCore.Mvc;

namespace BookingService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookingsController : ControllerBase
{
    private static List<object> bookings = new List<object>
    {
        new { bookingId = 101, flightId = 1, passengerId = 201 }
    };

    [HttpGet]
    public IActionResult GetBookings()
    {
        return Ok(bookings);
    }

    [HttpPost]
    public IActionResult AddBooking([FromBody] dynamic booking)
    {
        bookings.Add(booking);
        return Ok(booking);
    }
}