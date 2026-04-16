using FlightService.Models;
using Microsoft.EntityFrameworkCore;
using FlightService.Services;

namespace FlightService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Flight>? Flights { get; set; }
    }
}
