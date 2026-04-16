using Microsoft.EntityFrameworkCore;
using PassengerService.Models;

namespace PassengerService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Passenger>? Passengers { get; set; }
    }
}
