using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TurkeyDB.Data;
using TurkeyDB.Model;

namespace TurkeyDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DagController : Controller
    {
        private readonly TurkeyDBContext _context;

        public DagController(TurkeyDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("HepsiniGetir")]
        public async Task<ActionResult<IEnumerable<Mountain>>> HepsiniGetir()
        {
            return await _context.Mountains.ToListAsync();
        }
    }
}
