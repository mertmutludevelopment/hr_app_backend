using HrApp.Models;
using HrApp.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HrApp.Controllers
{
    [Route("api/declinedLeaves")]
    [ApiController]
    public class DeclinedLeaveController : ControllerBase 
    {
        private readonly RepositoryContext _context;

        public DeclinedLeaveController(RepositoryContext context)
        {
            _context = context;
        }

        [HttpGet("getAllDeclinedLeaves")]
        public IActionResult GetAllDeclinedLeaves()
        {
            var declinedLeaves = _context.DeclinedLeaves;
            return Ok(declinedLeaves);
        }

        [HttpPost("createNewDeclinedLeave")]
        public IActionResult CreateNewDeclinedLeave([FromBody] DeclinedLeave declinedLeave)
        {
            try
            {
                if (declinedLeave is null)
                {
                    return BadRequest();
                }
                else
                {
                    _context.DeclinedLeaves.Add(declinedLeave);
                    _context.SaveChanges();
                    return StatusCode(201, declinedLeave);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("getDeclinedLeavesByUser/{userId:int}")]
        public IActionResult GetDeclinedLeavesByUser([FromRoute] int userId)
        {
            try
            {
                var declinedLeaves = _context.DeclinedLeaves
                    .Where(leave => leave.UserId == userId)
                    .ToList();

                if (declinedLeaves == null || declinedLeaves.Count == 0)
                {
                    return NotFound();
                }

                return Ok(declinedLeaves);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
