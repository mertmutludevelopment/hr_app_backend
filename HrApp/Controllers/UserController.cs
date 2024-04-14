using HrApp.Models;
using HrApp.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HrApp.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly RepositoryContext _context;

        public UserController(RepositoryContext contex)
        {
            _context = contex;

        }


        [HttpPost("userVerification")]
        public IActionResult UserVerification([FromBody] User user)
        {
            var userModel = _context.Users.FirstOrDefault(x => x.Email == user.Email && x.Password == user.Password);

            if (userModel is null)
            {
                return BadRequest();
            }

            return Ok(userModel);


        }


        [HttpGet("getAllUsers")]
        public IActionResult GetAllUsers()
        {
            var users = _context.Users;
            return Ok(users);
        }


        [HttpPost("createNewUser")]
        public IActionResult CreateNewUser([FromBody] User user)
        {
            try
            {
                if (user is null)
                {
                    return BadRequest();
                }
                else
                {
                    _context.Users.Add(user);
                    _context.SaveChanges();
                    return StatusCode(201, user);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [HttpPut("updateUserEmail/{id}")]
        public IActionResult UpdateUserEmail(int id, [FromBody] User updatedUser)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id); 
                

            if (user == null)
            {
                return NotFound();
            }

            user.Email = updatedUser.Email;

            _context.SaveChanges();

            return Ok(user);
        }

        [HttpPut("updateUserPassword/{id}")]
        public IActionResult UpdateUserPassword(int id, [FromBody] User updatedUser)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);


            if (user == null)
            {
                return NotFound();
            }

            user.Password = updatedUser.Password;

            _context.SaveChanges();

            return Ok(user);
        }


        [HttpPut("updateUserDepartment/{id}")]
        public IActionResult UpdateUserDepartment(int id, [FromBody] User updatedUser)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);


            if (user == null)
            {
                return NotFound();
            }

            user.Department = updatedUser.Department;

            _context.SaveChanges();

            return Ok(user);
        }

        [HttpPut("updateUserPhoneNumber/{id}")]
        public IActionResult UpdateUserPhoneNumber(int id, [FromBody] User updatedUser)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);


            if (user == null)
            {
                return NotFound();
            }

            user.PhoneNumber = updatedUser.PhoneNumber;

            _context.SaveChanges();

            return Ok(user);
        }

        [HttpPut("updateUserFullname/{id}")]
        public IActionResult UpdateUserFullname(int id, [FromBody] User updatedUser)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);


            if (user == null)
            {
                return NotFound();
            }

            user.Fullname = updatedUser.Fullname;

            _context.SaveChanges();

            return Ok(user);
        }

        [HttpPut("updateUserLeaveDay/{id}")]
        public IActionResult UpdateUserLeaveDay(int id, [FromBody] User updatedUser)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);


            if (user == null)
            {
                return NotFound();
            }

            user.LeaveDay = updatedUser.LeaveDay;

            _context.SaveChanges();

            return Ok(user);
        }


        [HttpGet("getUsedDepartments")]
        public IActionResult GetUsedDepartments()
        {
            var usedDepartments = _context.Users
                .Where(user => !string.IsNullOrEmpty(user.Department))
                .Select(user => user.Department)
                .Distinct()
                .ToList();

            return Ok(usedDepartments);
        }

        [HttpPost("getAllUsersByDepartment/{departmentName}")]
        public IActionResult GetAllUsersByDepartment([FromRoute] string departmentName)
        {
            if (string.IsNullOrWhiteSpace(departmentName))
            {
                return NotFound("Department name cannot be null or empty.");
            }

            var usersInDepartment = _context.Users
                .Where(user => user.Department.ToLower() == departmentName.ToLower())
                .ToList();

            return Ok(usersInDepartment);
        }

        [HttpPost("getSearchedUsers")]
        public IActionResult GetSearchedUsers([FromBody] User user) {

            if (user is null)
            {
                return BadRequest();
            }

            var searchedUsers = _context.Users
                .Where(u => u.Fullname.ToLower().Contains(user.Fullname.ToLower())).ToList();

            return Ok(searchedUsers);
        }




    }


}

