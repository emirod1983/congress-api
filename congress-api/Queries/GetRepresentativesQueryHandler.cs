using congress_api.Models;
using congress_api.Repositories;
using MediatR;

namespace congress_api.Queries
{
    public class GetRepresentativesQueryHandler : IRequestHandler<GetRepresentativesQuery, List<ReprCamaraAlta>>
    {
        private readonly ICongressRepository _repository;

        public GetRepresentativesQueryHandler(ICongressRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<ReprCamaraAlta>> Handle(GetRepresentativesQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetSenadores();
        }
    }
}
