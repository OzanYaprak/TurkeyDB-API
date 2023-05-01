using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TurkeyDB.Data;
using TurkeyDB.Model;

namespace TurkeyDB.Controllers
{
    public class KullanıcıController : Controller
    {
        [Route("api/[controller]")]
        [ApiController]
        public class KullaniciController : ControllerBase
        {
            private readonly TurkeyDBContext _context;

            public KullaniciController(TurkeyDBContext context)
            {
                _context = context;
            }

            // GET: api/Kullanici
            [HttpGet]
            public async Task<ActionResult<IEnumerable<User>>> GetUsers()
            {
                return await _context.Users.ToListAsync();
            }

            // GET: api/Kullanici/5
            [HttpGet("{id}")]
            public async Task<ActionResult<User>> GetUser(int id)
            {
                var user = await _context.Users.FindAsync(id);

                if (user == null)
                {
                    return NotFound();
                }

                return user;
            }

            // PUT: api/Kullanici/5
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            [HttpPut("{id}")]
            public async Task<IActionResult> PutUser(int id, User user)
            {
                if (id != user.UserID)
                {
                    return BadRequest();
                }

                _context.Entry(user).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(id))
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

            // POST: api/Kullanici
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            [HttpPost]
            public async Task<ActionResult<User>> PostUser(User user)
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetUser", new { id = user.UserID }, user);
            }

            // DELETE: api/Kullanici/5
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteUser(int id)
            {
                var user = await _context.Users.FindAsync(id);
                if (user == null)
                {
                    return NotFound();
                }

                _context.Users.Remove(user);
                await _context.SaveChangesAsync();

                return NoContent();
            }

            private bool UserExists(int id)
            {
                return _context.Users.Any(e => e.UserID == id);
            }
        }
    }
}
