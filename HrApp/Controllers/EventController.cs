using HrApp.Models;
using HrApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HrApp.Controllers
{
    [Route("api/events")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly RepositoryContext _context;

        public EventController(RepositoryContext context)
        {
            _context = context;
        }

        [HttpGet("getAllEvents")]
        public IActionResult GetAllEvents() {
            var events = _context.Events;
            return Ok(events);

        }


        [HttpPost("createNewEvent")]
        public IActionResult CreateNewEvent([FromBody] Event newEvent)
        {
            try
            {
                if (newEvent is null)
                {
                    return BadRequest();
                }
                else
                {
                    _context.Events.Add(newEvent);
                    _context.SaveChanges();
                    return StatusCode(201, newEvent);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpDelete("deleteEvent/{eventId}")]
        public IActionResult DeleteEvent(int eventId)
        {
            try
            {
                var eventToDelete = _context.Events.FirstOrDefault(e => e.Id == eventId);

                if (eventToDelete == null)
                {
                    return NotFound($"Event with ID {eventId} not found.");
                }

                _context.Events.Remove(eventToDelete);
                _context.SaveChanges();

                return Ok(); 
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
