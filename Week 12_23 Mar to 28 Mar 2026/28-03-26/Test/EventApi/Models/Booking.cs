namespace EventApi.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public string UserId { get; set; }
        public int SeatsBooked { get; set; }
    }
}