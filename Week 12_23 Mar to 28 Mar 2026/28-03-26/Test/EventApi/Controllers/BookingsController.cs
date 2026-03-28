using Microsoft.AspNetCore.Mvc;
using EventApi.Models;
using EventApi.DTOs;

namespace EventApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingsController : ControllerBase
    {
        private static List<Booking> bookings = new List<Booking>();
        private static int bookingId = 1;

        // reference to events list
        private static List<Event> events = EventsController.GetEventsList();

        [HttpPost]
        public IActionResult Book([FromBody] BookingDto dto)
        {
            var ev = events.FirstOrDefault(e => e.Id == dto.EventId);

            if (ev == null)
                return NotFound("Event not found");

            if (dto.SeatsBooked > ev.AvailableSeats)
                return BadRequest("Not enough seats");

            ev.AvailableSeats -= dto.SeatsBooked;

            var booking = new Booking
            {
                Id = bookingId++,
                EventId = dto.EventId,
                UserId = "User1",
                SeatsBooked = dto.SeatsBooked
            };

            bookings.Add(booking);

            return Ok("Booking Successful");
        }

        [HttpGet]
        public IActionResult GetBookings()
        {
            return Ok(bookings);
        }
    }
}