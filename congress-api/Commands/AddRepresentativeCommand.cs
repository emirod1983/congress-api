using congress_api.Models;
using MediatR;

namespace congress_api.Commands
{
    public class AddRepresentativeCommand : IRequest<string>
    {
        public SenadoresVigentes Representante { get; }

        public AddRepresentativeCommand(SenadoresVigentes representante)
        {
            this.Representante = representante;
        }
    }
}
