namespace FlightAPI.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public string? FlightCode { get; set; }
        public int Seat { get; set; }
        public string? FlightType { get; set; }
        public string? Company { get; set; }
    }
}