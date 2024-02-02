using congress_api.Models;
using congress_api.Repositories;
using MediatR;

namespace congress_api.Queries
{
    public class GetRepresentantesCamaraBajaQueryHandler(ICongressRepository repository) : IRequestHandler<GetRepresentantesCamaraBajaQuery, List<ReprCamaraBaja>>
    {
        public async Task<List<ReprCamaraBaja>> Handle(GetRepresentantesCamaraBajaQuery request, CancellationToken cancellationToken)
        {
            return await repository.GetDiputados();
        }
    }
}
