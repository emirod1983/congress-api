using congress_api.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace congress_api.Queries
{
    public class CreateSchemaQueryHandler(CongressDbContext context) : IRequestHandler<CreateSchemaQuery, Unit>
    {
        public async Task<Unit> Handle(CreateSchemaQuery request, CancellationToken cancellationToken)
        {
            await ReadAndSaveEntitiesAsync<SenadoresVigentes>("assets/senadores_vigentes.json", context.SenadoresVigentes);
            await ReadAndSaveEntitiesAsync<DiputadosVigentes>("assets/diputados_vigentes.json", context.DiputadosVigentes);

            return Unit.Value;
        }

        private async Task ReadAndSaveEntitiesAsync<T>(string filePath, DbSet<T> dbSet) where T : class
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                var json = await reader.ReadToEndAsync();
                var entities = JsonConvert.DeserializeObject<List<T>>(json);

                if (entities != null && entities.Any())
                {
                    await dbSet.AddRangeAsync(entities);
                    await context.SaveChangesAsync();
                }
            }
        }
    }
}
