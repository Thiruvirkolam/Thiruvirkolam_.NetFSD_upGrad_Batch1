using PassengerService.Data;
using PassengerService.DTOs;
using PassengerService.Models;

namespace PassengerService.Services
{
    public interface IPassengerService
    {
        List<Passenger>? GetAll();
        Passenger? GetById(int id);
        Passenger? Add(PassengerDto dto);
        Passenger? Update(int id, PassengerDto dto);
        bool Delete(int id);
    }

    public class PassengerService : IPassengerService
    {
        private readonly AppDbContext _context;

        public PassengerService(AppDbContext context)
        {
            _context = context;
        }

        public List<Passenger>? GetAll()
        {
            return _context.Passengers?.ToList();
        }

        public Passenger? GetById(int id)
        {
            return _context.Passengers?.Find(id);
        }

        public Passenger? Add(PassengerDto dto)
        {
            var p = new Passenger
            {
                Name = dto.Name,
                Age = dto.Age
            };

            _context.Passengers?.Add(p);
            _context.SaveChanges();
            return p;
        }

        public Passenger? Update(int id, PassengerDto dto)
        {
            var p = _context.Passengers?.Find(id);
            if (p == null) return null;

            p.Name = dto.Name;
            p.Age = dto.Age;

            _context.SaveChanges();
            return p;
        }

        public bool Delete(int id)
        {
            var p = _context.Passengers?.Find(id);
            if (p == null) return false;

            _context.Passengers?.Remove(p);
            _context.SaveChanges();
            return true;
        }
    }
}