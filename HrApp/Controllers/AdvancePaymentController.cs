using HrApp.Models;
using HrApp.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HrApp.Controllers
{
    [Route("api/advancePayments")]
    [ApiController]
    public class AdvancePaymentController : ControllerBase
    {

        private readonly RepositoryContext _context;

        public AdvancePaymentController(RepositoryContext context)
        {
            _context = context;
        }

        [HttpGet("getAllAdvancePayments")]
        public IActionResult GetAllAdvancePayments()
        {
            var advancePayments = _context.AdvancePayments;
            return Ok(advancePayments);

        }

        [HttpPost("createNewAdvancePayment")]
        public IActionResult CreateNewAdvancePayment([FromBody] AdvancePayment advancePayment)
        {
            try
            {
                if (advancePayment is null)
                {
                    return BadRequest();
                }
                else
                {
                    _context.AdvancePayments.Add(advancePayment);
                    _context.SaveChanges();
                    return StatusCode(201, advancePayment);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [HttpGet("getAdvancePaymentByUserBool/{userId:int}")]
        public IActionResult GetAdvancePaymentByUserBool([FromRoute] int userId)
        {
            try
            {
                var advancePayments = _context.AdvancePayments
                    .Where(a => a.UserId == userId)
                    .ToList();

                if (advancePayments == null || advancePayments.Count == 0)
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


        [HttpGet("getAdvancePaymentByUser/{userId:int}")]
        public IActionResult GetAdvancePaymentByUser([FromRoute] int userId)
        {
            try
            {
                var advancePayments = _context.AdvancePayments
                    .Where(a => a.UserId == userId)
                    .ToList();

                if (advancePayments == null || advancePayments.Count == 0)
                {
                    return NotFound();
                }

                return Ok(advancePayments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("deleteAdvancePayment/{id:int}")]
        public IActionResult DeleteAdvancePayment([FromRoute] int id)
        {
            try
            {
                var advancePaymentToDelete = _context.AdvancePayments.Find(id);

                if (advancePaymentToDelete == null)
                {
                    return NotFound();
                }

                _context.AdvancePayments.Remove(advancePaymentToDelete);
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
