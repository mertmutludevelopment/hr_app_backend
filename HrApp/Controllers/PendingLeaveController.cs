using HrApp.Models;
using HrApp.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HrApp.Controllers
{
    [Route("api/pendingLeaves")]
    [ApiController]
    public class PendingLeaveController : ControllerBase
    {
        private readonly RepositoryContext _context;

        public PendingLeaveController(RepositoryContext context)
        {
            _context = context;
        }

        [HttpGet("getAllPendingLeaves")]
        public IActionResult GetAllPendingLeaves()
        {
            var pendingLeaves = _context.PendingLeaves;
            return Ok(pendingLeaves);

        }

        [HttpPost("createNewPendingLeave")]
        public IActionResult CreateNewPendingLeave([FromBody] PendingLeave pendingLeave)
        {
            try
            {
                if (pendingLeave is null)
                {
                    return BadRequest();
                }
                else
                {
                    _context.PendingLeaves.Add(pendingLeave);
                    _context.SaveChanges();
                    return StatusCode(201, pendingLeave);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet("getPendingLeavesByUser/{userId:int}")]
        public IActionResult GetPendingLeavesByUser([FromRoute] int userId)
        {
            try
            {
                var pendingLeaves = _context.PendingLeaves
                    .Where(leave => leave.UserId == userId)
                    .ToList();

                if (pendingLeaves == null || pendingLeaves.Count == 0)
                {
                    return NotFound();
                }

                return Ok(pendingLeaves);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("deletePendingLeave/{id:int}")]
        public IActionResult DeletePendingLeave([FromRoute] int id)
        {
            try
            {
                var pendingLeaveToDelete = _context.PendingLeaves.Find(id);

                if (pendingLeaveToDelete == null)
                {
                    return NotFound();
                }

                _context.PendingLeaves.Remove(pendingLeaveToDelete);
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
