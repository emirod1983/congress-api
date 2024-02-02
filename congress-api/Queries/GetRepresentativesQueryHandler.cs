using congress_api.Models;
using congress_api.Repositories;
using MediatR;

namespace congress_api.Queries
{
    public class GetRepresentativesQueryHandler(ICongressRepository repository) : IRequestHandler<GetRepresentativesQuery, List<ReprCamaraAlta>>
    {
        public async Task<List<ReprCamaraAlta>> Handle(GetRepresentativesQuery request, CancellationToken cancellationToken)
        {
            return await repository.GetSenadores();
        }
    }
}
