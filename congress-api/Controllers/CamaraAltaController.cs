using congress_api.Commands;
using congress_api.Models;
using congress_api.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace congress_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CamaraAltaController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CamaraAltaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReprCamaraAlta>>> GetRepresentatives()
        {
            var query = new GetRepresentativesQuery();

            return Ok(await _mediator.Send(query));
        }

        [HttpPost("Representante")]
        public async Task<ActionResult<ReprCamaraAlta>> AddRepresentative(ReprCamaraAlta representante, CancellationToken cancellationToken)
        {
            var command = new AddRepresentativeCommand(representante);

            return Ok(await _mediator.Send(command, cancellationToken));
        }
    }
}
