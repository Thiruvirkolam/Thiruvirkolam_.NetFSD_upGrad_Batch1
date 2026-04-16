using BookingService.Data;
using BookingService.DTOs;
using BookingService.Models;

namespace BookingService.Services
{
    public interface IBookingService
    {
        List<Booking>? GetAll();
        Booking? GetById(int id);
        Booking? Add(BookingDto dto);
        Booking? Update(int id, BookingDto dto);
        bool Delete(int id);
    }

    public class BookingService : IBookingService
    {
        private readonly AppDbContext _context;

        public BookingService(AppDbContext context)
        {
            _context = context;
        }

        public List<Booking>? GetAll()
        {
            return _context.Bookings?.ToList();
        }

        public Booking? GetById(int id)
        {
            return _context.Bookings?.Find(id);
        }

        public Booking? Add(BookingDto dto)
        {
            var b = new Booking
            {
                FlightId = dto.FlightId,
                PassengerId = dto.PassengerId
            };

            _context.Bookings?.Add(b);
            _context.SaveChanges();
            return b;
        }

        public Booking? Update(int id, BookingDto dto)
        {
            var b = _context.Bookings?.Find(id);
            if (b == null) return null;

            b.FlightId = dto.FlightId;
            b.PassengerId = dto.PassengerId;

            _context.SaveChanges();
            return b;
        }

        public bool Delete(int id)
        {
            var b = _context.Bookings?.Find(id);
            if (b == null) return false;

            _context.Bookings?.Remove(b);
            _context.SaveChanges();
            return true;
        }
    }
}