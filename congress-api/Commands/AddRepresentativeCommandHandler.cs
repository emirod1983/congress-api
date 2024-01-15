using congress_api.Models;
using congress_api.Queries;
using congress_api.Repositories;
using MediatR;

namespace congress_api.Commands
{
    public class AddRepresentativeCommandHandler : IRequestHandler<AddRepresentativeCommand, string>
    {
        private readonly ICongressRepository _repository;

        public AddRepresentativeCommandHandler(ICongressRepository repository)
        {
            _repository = repository;
        }

        public async Task<string> Handle(AddRepresentativeCommand request, CancellationToken cancellationToken)
        {
            return await _repository.AddSenador(request.Representante);
        }
    }
}
