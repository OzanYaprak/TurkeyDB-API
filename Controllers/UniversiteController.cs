using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using TurkeyDB.Data;
using TurkeyDB.Model;

namespace TurkeyDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniversiteController : Controller
    {

            private readonly TurkeyDBContext _context;

            public UniversiteController(TurkeyDBContext context)
            {
                _context = context;
            }



            [HttpGet]
            [Route("HepsiniGetir")]
            public async Task<IEnumerable<University>> FakulteleriGetir()
            {
                return await _context.Universities.ToListAsync();
            }
        
    }
}
