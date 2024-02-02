using congress_api.Models;
using congress_api.Repositories;
using MediatR;

namespace congress_api.Queries
{
    public class GetRepresentantesCamaraAltaQueryHandler(ICongressRepository repository) : IRequestHandler<GetRepresentantesCamaraAltaQuery, List<SenadoresVigentes>>
    {
        public async Task<List<SenadoresVigentes>> Handle(GetRepresentantesCamaraAltaQuery request, CancellationToken cancellationToken)
        {
            return await repository.GetSenadores();
        }
    }
}
