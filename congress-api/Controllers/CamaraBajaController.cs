using congress_api.Models;
using congress_api.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace congress_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CamaraBajaController(IMediator mediator, CongressDbContext context) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReprCamaraBaja>>> GetRepresentatives()
        {
            var query = new GetRepresentantesCamaraBajaQuery();

            return Ok(await mediator.Send(query));
        }
    }
}
