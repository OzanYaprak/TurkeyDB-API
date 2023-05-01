using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TurkeyDB.Data;
using TurkeyDB.Model;

namespace TurkeyDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GolController : Controller
    {
        private readonly TurkeyDBContext _context;

        public GolController(TurkeyDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("HepsiniGetir")]
        public async Task<ActionResult<IEnumerable<Lake>>> HepsiniGetir()
        {
            return await _context.Lakes.ToListAsync();
        }
    }
}
