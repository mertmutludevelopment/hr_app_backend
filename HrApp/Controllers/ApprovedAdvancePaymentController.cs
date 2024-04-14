using HrApp.Models;
using HrApp.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HrApp.Controllers
{
    [Route("api/approvedAdvancePayment")]
    [ApiController]
    public class ApprovedAdvancePaymentController : ControllerBase
    {


        private readonly RepositoryContext _context;

        public ApprovedAdvancePaymentController(RepositoryContext context)
        {
            _context = context;
        }

        [HttpGet("getAllApprovedAdvancePayments")]
        public IActionResult GetAllApprovedAdvancePayments()
        {
            var approvedAdvancePayments = _context.ApprovedAdvancePayments;
            return Ok(approvedAdvancePayments);

        }

        [HttpPost("createNewApprovedAdvancePayment")]
        public IActionResult CreateNewApprovedAdvancePayment([FromBody] ApprovedAdvancePayment approvedAdvancePayment)
        {
            try
            {
                if (approvedAdvancePayment is null)
                {
                    return BadRequest();
                }
                else
                {
                    _context.ApprovedAdvancePayments.Add(approvedAdvancePayment);
                    _context.SaveChanges();
                    return StatusCode(201, approvedAdvancePayment);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet("getApprovedAdvancePaymentByUserBool/{userId:int}")]
        public IActionResult GetApprovedAdvancePaymentByUserBool([FromRoute] int userId)
        {
            try
            {
                var approvedAdvancePayments = _context.ApprovedAdvancePayments
                    .Where(a => a.UserId == userId)
                    .ToList();

                if (approvedAdvancePayments == null || approvedAdvancePayments.Count == 0)
                {
                    return NotFound();
                }

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("getApprovedAdvancePaymentByUser/{userId:int}")]
        public IActionResult GetApprovedAdvancePaymentByUser([FromRoute] int userId)
        {
            try
            {
                var approvedAdvancePayments = _context.ApprovedAdvancePayments
                    .Where(a => a.UserId == userId)
                    .ToList();

                if (approvedAdvancePayments == null || approvedAdvancePayments.Count == 0)
                {
                    return NotFound();
                }

                return Ok(approvedAdvancePayments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
