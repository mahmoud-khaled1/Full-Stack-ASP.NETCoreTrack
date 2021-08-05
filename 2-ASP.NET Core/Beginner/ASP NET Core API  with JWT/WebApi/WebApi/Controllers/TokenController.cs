using WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Linq;
using BC = BCrypt.Net.BCrypt;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        public IConfiguration _configuration;
        private readonly BookStoreAPiContext _context;

        public TokenController(IConfiguration config, BookStoreAPiContext context)
        {
            _configuration = config;
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult>Post(Userr _user)
        {
            if(_user != null&& _user.UserEmail!=null&& _user.UserPassword!=null)
            {
                var user = await GetUser(_user.UserEmail, _user.UserPassword);

                if(user!=null||BC.Verify(_user.UserPassword,user.UserPassword))
                {
                    //To Create Token to user 
                    var claims = new[]
                    {
                       new Claim(JwtRegisteredClaimNames.Sub,_configuration["Jwt:Subject"]),
                       new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                       new Claim (JwtRegisteredClaimNames.Iat,DateTime.UtcNow.ToString()),
                       new Claim  ("id", user.UserId.ToString()),
                       new Claim  ("FirstName", user.UserFirstName),
                       new Claim  ("LastName", user.UserLastName),
                       new Claim  ("UserName", user.UserEmail),
                       new Claim  ("Email", user.UserEmail)

                    };
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"], claims, expires: DateTime.UtcNow.AddDays(1), signingCredentials: signIn);

                    // return the Token 
                    return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                }
                else
                {
                    return BadRequest("Invalid email and password");

                }
            }
            else
            {
                return BadRequest();
            }
        }

        private async Task<Userr> GetUser(string email, string password)
        {
            return await _context.Userrs.FirstOrDefaultAsync(u => u.UserEmail == email && u.UserPassword == password);
        }

        private async Task<Userr> CheckUserEmail(string email)
        {
            return await _context.Userrs.FirstOrDefaultAsync(u => u.UserEmail == email);
        }

    }
}
