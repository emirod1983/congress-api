using congress_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace congress_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CamaraBajaController(CongressDbContext context) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReprCamaraBaja>>> GetRepresentatives()
        {
            return await context.ReprCamaraBaja.ToListAsync();
        }

        [HttpPost("Representante")]
        public async Task<ActionResult<ReprCamaraBaja>> AddRepresentative(ReprCamaraBaja representative)
        {
            context.ReprCamaraBaja.Add(representative);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(ReprCamaraBaja), new { id = representative.Id }, representative);
        }
    }
}
