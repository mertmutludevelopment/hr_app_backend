using HrApp.Models;
using HrApp.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HrApp.Controllers
{
    [Route("api/approvedLeaves")]
    [ApiController]
    public class ApprovedLeaveController : ControllerBase
    {

        private readonly RepositoryContext _context;

        public ApprovedLeaveController(RepositoryContext context)
        {
            _context = context;
        }

        [HttpGet("getAllApprovedLeaves")]
        public IActionResult GetAllApprovedLeaves()
        {
            var approvedLeaves = _context.ApprovedLeaves;
            return Ok(approvedLeaves);
        }

        [HttpPost("createNewApprovedLeave")]
        public IActionResult CreateNewApprovedLeave([FromBody] ApprovedLeave approvedLeave)
        {
            try
            {
                if(approvedLeave is null)
                {
                    return BadRequest();
                }
                else
                {
                    _context.ApprovedLeaves.Add(approvedLeave);
                    _context.SaveChanges();
                    return StatusCode(201, approvedLeave);
                }
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("getApprovedLeavesByUser/{userId:int}")]
        public IActionResult GetApprovedLeavesByUser([FromRoute] int userId)
        {
            try
            {
                var approvedLeaves = _context.ApprovedLeaves
                    .Where(leave => leave.UserId == userId)
                    .ToList();

                if (approvedLeaves == null || approvedLeaves.Count == 0)
                {
                    return NotFound();
                }

                return Ok(approvedLeaves);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
