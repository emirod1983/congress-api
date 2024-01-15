using congress_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace congress_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CamaraBajaController : ControllerBase
    {
        private readonly CongressDbContext _context;

        public CamaraBajaController(CongressDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReprCamaraBaja>>> GetRepresentatives()
        {
            return await _context.ReprCamaraBaja.ToListAsync();
        }

        [HttpPost("Representante")]
        public async Task<ActionResult<ReprCamaraBaja>> AddRepresentative(ReprCamaraBaja representative)
        {
            _context.ReprCamaraBaja.Add(representative);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(ReprCamaraBaja), new { id = representative.Id }, representative);
        }
    }
}
