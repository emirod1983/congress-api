using congress_api.Models;
using congress_api.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace congress_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DbSchemaController(IMediator mediator) : ControllerBase
    {
        [HttpPost("CreateSchema")]
        public async Task<ActionResult> CreateSchema(CancellationToken cancellationToken)
        {
            try
            {
                var request = new CreateSchemaQuery();

                await mediator.Send(request, cancellationToken);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
    }
}
