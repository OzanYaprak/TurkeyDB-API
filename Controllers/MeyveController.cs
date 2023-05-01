using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TurkeyDB.Data;
using TurkeyDB.Model;

namespace TurkeyDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeyveController : ControllerBase
    {
        private readonly TurkeyDBContext _context;

        public MeyveController(TurkeyDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("HepsiniGetir")]
        public async Task<ActionResult<IEnumerable<Fruit>>> HepsiniGetir()
        {
            return await _context.Fruits.ToListAsync();
        }
    }
}
