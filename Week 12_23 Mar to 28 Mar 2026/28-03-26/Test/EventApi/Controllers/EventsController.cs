using Microsoft.AspNetCore.Mvc;
using EventApi.Models;

namespace EventApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        private static List<Event> events = new List<Event>();
        private static int idCounter = 1;

        // ✅ GET all events
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(events);
        }

        // ✅ POST create event
        [HttpPost]
        public IActionResult Create([FromBody] Event e)
        {
            if (e == null)
                return BadRequest("Invalid data");

            e.Id = idCounter++;
            events.Add(e);

            return Ok("Event Created");
        }

        // ✅ GET event by ID
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var ev = events.FirstOrDefault(e => e.Id == id);

            if (ev == null)
                return NotFound("Event not found");

            return Ok(ev);
        }

        // ✅ UPDATE event
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Event updatedEvent)
        {
            var ev = events.FirstOrDefault(e => e.Id == id);

            if (ev == null)
                return NotFound("Event not found");

            ev.Title = updatedEvent.Title;
            ev.Description = updatedEvent.Description;
            ev.Location = updatedEvent.Location;
            ev.AvailableSeats = updatedEvent.AvailableSeats;

            return Ok("Event Updated");
        }

        // ✅ DELETE event
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var ev = events.FirstOrDefault(e => e.Id == id);

            if (ev == null)
                return NotFound("Event not found");

            events.Remove(ev);

            return Ok("Event Deleted");
        }

        // ✅ SHARE event list with BookingController
        public static List<Event> GetEventsList()
        {
            return events;
        }
    }
}