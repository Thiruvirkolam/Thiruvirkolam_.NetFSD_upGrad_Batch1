using FlightService.Data;
using FlightService.DTOs;
using FlightService.Models;

namespace FlightService.Services
{
    public interface IFlightService
    {
        List<Flight>? GetAll();
        Flight? GetById(int id);
        Flight? Add(FlightDto dto);
        Flight? Update(int id, FlightDto dto);
        bool Delete(int id);
    }

    public class FlightService : IFlightService
    {
        private readonly AppDbContext _context;

        public FlightService(AppDbContext context)
        {
            _context = context;
        }

        public List<Flight>? GetAll()
        {
            return _context.Flights?.ToList();
        }

        public Flight? GetById(int id)
        {
            return _context.Flights?.Find(id);
        }

        public Flight? Add(FlightDto dto)
        {
            var f = new Flight
            {
                FlightNumber = dto.FlightNumber,
                Source = dto.Source,
                Destination = dto.Destination
            };

            _context.Flights?.Add(f);
            _context.SaveChanges();
            return f;
        }

        public Flight? Update(int id, FlightDto dto)
        {
            var flight = _context.Flights?.Find(id);
            if (flight == null) return null;

            flight.FlightNumber = dto.FlightNumber;
            flight.Source = dto.Source;
            flight.Destination = dto.Destination;

            _context.SaveChanges();
            return flight;
        }

        public bool Delete(int id)
        {
            var flight = _context.Flights?.Find(id);
            if (flight == null) return false;

            _context.Flights?.Remove(flight);
            _context.SaveChanges();
            return true;
        }
    }
}