using Microsoft.AspNetCore.Mvc;
using EventApi.Models;

namespace EventApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private static List<User> users = new List<User>();
        private static int idCounter = 1;

        // ✅ REGISTER
        [HttpPost("register")]
        public IActionResult Register([FromBody] User user)
        {
            if (users.Any(u => u.Username == user.Username))
                return BadRequest("User already exists");

            user.Id = idCounter++;
            users.Add(user);

            return Ok("User Registered");
        }

        // ✅ LOGIN
        [HttpPost("login")]
        public IActionResult Login([FromBody] User user)
        {
            var u = users.FirstOrDefault(x =>
                x.Username == user.Username &&
                x.Password == user.Password);

            if (u == null)
                return Unauthorized("Invalid Credentials");

            return Ok("Login Successful");
        }
    }
}