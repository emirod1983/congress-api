using congress_api.Commands;
using congress_api.Models;
using congress_api.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace congress_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CamaraAltaController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SenadoresVigentes>>> GetRepresentatives()
        {
            var query = new GetRepresentantesCamaraAltaQuery();

            return Ok(await mediator.Send(query));
        }

        [HttpPost("Representante")]
        public async Task<ActionResult<SenadoresVigentes>> AddRepresentative(SenadoresVigentes representante, CancellationToken cancellationToken)
        {
            var command = new AddRepresentativeCommand(representante);

            return Ok(await mediator.Send(command, cancellationToken));
        }
    }
}
