using HrApp.Models;
using HrApp.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HrApp.Controllers
{
    [Route("api/notifications")]
    [ApiController]
    public class NotificationController : ControllerBase
    {

        private readonly RepositoryContext _context;

        public NotificationController(RepositoryContext context)
        {
            _context = context;
        }

        [HttpGet("getAllNotifications")]
        public IActionResult GetAllNotifications()
        {
            var notifications = _context.Notifications;
            return Ok(notifications);
        }

        [HttpPost("createNewNotification")]
        public IActionResult CreateNewNotification([FromBody] Notification notification)
        {
            try
            {
                if (notification is null)
                {
                    return BadRequest();
                }
                else
                {
                    _context.Notifications.Add(notification);
                    _context.SaveChanges();
                    return StatusCode(201, notification);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("getNotificationsByUser/{userId:int}")]
        public IActionResult GetNotificationsByUser([FromRoute] int userId)
        {
            try
            {
                var notifications = _context.Notifications
                .Where(n => (n.NotificationReceiverId == userId && n.NotificationReceiverId != null) || n.NotificationReceiverId == null)
                .ToList();

                if (notifications == null || notifications.Count == 0)
                {
                    return NotFound();
                }

                return Ok(notifications);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete("deleteNotification/{id:int}")]
        public IActionResult DeleteNotification([FromRoute] int id)
        {
            try
            {
                var notificationToDelete = _context.Notifications.Find(id);

                if (notificationToDelete == null)
                {
                    return NotFound();
                }

                _context.Notifications.Remove(notificationToDelete);
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
