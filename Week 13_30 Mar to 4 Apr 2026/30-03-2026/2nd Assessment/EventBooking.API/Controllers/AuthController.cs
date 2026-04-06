using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using EventBooking.API.Models;

namespace EventBooking.API.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel model)
        {
            if (model.Role == "admin")
            {
                // ✅ Admin login
                if (model.Username != "admin" || model.Password != "1234")
                    return Unauthorized();
            }
            else
            {
                // 🔥 UPDATED USER LOGIN
                if (model.Username != "Chitransh" || model.Password != "1234")
                    return Unauthorized();
            }

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, model.Username),
                new Claim(ClaimTypes.Role, model.Role)
            };

            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes("super_secret_key_12345678901234567890"));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddHours(2),
                signingCredentials: creds
            );

            return Ok(new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token)
            });
        }
    }
}