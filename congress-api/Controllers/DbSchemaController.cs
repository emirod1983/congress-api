using congress_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace congress_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DbSchemaController : ControllerBase
    {
        private readonly CongressDbContext _context;

        public DbSchemaController(CongressDbContext context)
        {
            _context = context;
        }

        [HttpPost("CreateSchema")]
        public async Task<ActionResult<ReprCamaraAlta>> CreateSchema()
        {
            using StreamReader senReader = new("assets/senadores_vigentes.json");
            var senJson = await senReader.ReadToEndAsync();
            List<ReprCamaraAlta> senResponse = JsonConvert.DeserializeObject<List<ReprCamaraAlta>>(senJson) ?? [];

            _context.ReprCamaraAlta.AddRange(senResponse);
            await _context.SaveChangesAsync();

            using StreamReader dipReader = new("assets/diputados_vigentes.json");
            var dipJson = await dipReader.ReadToEndAsync();
            List<ReprCamaraBaja> dipResponse = JsonConvert.DeserializeObject<List<ReprCamaraBaja>>(dipJson) ?? [];

            _context.ReprCamaraBaja.AddRange(dipResponse);
            await _context.SaveChangesAsync();


            return Ok();
        }
    }
}
