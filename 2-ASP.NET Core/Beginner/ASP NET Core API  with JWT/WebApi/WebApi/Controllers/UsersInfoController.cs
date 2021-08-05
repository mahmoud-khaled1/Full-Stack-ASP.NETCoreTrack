using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

using BC = BCrypt.Net.BCrypt;
namespace WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersInfoController : ControllerBase
    {
        private readonly BookStoreAPiContext _context;

        public UsersInfoController(BookStoreAPiContext context)
        {
            _context = context;
        }

        // GET: api/UsersInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Userr>>> GetUserrs()
        {
            return await _context.Userrs.ToListAsync();
        }

        // GET: api/UsersInfo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Userr>> GetUserr(int id)
        {
            var userr = await _context.Userrs.FindAsync(id);

            if (userr == null)
            {
                return NotFound();
            }

            return userr;
        }
        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<ActionResult<Userr>> PostUserr(Userr userr)
        {

            userr.UserPassword = BC.HashPassword(userr.UserPassword);
            _context.Userrs.Add(userr);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserrs", new { id = userr.UserId }, userr);
        }

        // PUT: api/UsersInfo/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserr(int id, Userr userr)
        {
            if (id != userr.UserId)
            {
                return BadRequest();
            }

            _context.Entry(userr).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserrExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        

        // DELETE: api/UsersInfo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserr(int id)
        {
            var userr = await _context.Userrs.FindAsync(id);
            if (userr == null)
            {
                return NotFound();
            }

            _context.Userrs.Remove(userr);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserrExists(int id)
        {
            return _context.Userrs.Any(e => e.UserId == id);
        }
    }
}
