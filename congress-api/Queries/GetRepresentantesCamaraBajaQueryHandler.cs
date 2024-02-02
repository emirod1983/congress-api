using congress_api.Models;
using congress_api.Repositories;
using MediatR;

namespace congress_api.Queries
{
    public class GetRepresentantesCamaraBajaQueryHandler(ICongressRepository repository) : IRequestHandler<GetRepresentantesCamaraBajaQuery, List<DiputadosVigentes>>
    {
        public async Task<List<DiputadosVigentes>> Handle(GetRepresentantesCamaraBajaQuery request, CancellationToken cancellationToken)
        {
            return await repository.GetDiputados();
        }
    }
}
