using congress_api.Models;
using congress_api.Repositories;
using MediatR;

namespace congress_api.Queries
{
    public class GetRepresentantesCamaraAltaQueryHandler(ICongressRepository repository) : IRequestHandler<GetRepresentantesCamaraAltaQuery, List<ReprCamaraAlta>>
    {
        public async Task<List<ReprCamaraAlta>> Handle(GetRepresentantesCamaraAltaQuery request, CancellationToken cancellationToken)
        {
            return await repository.GetSenadores();
        }
    }
}
