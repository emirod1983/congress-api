using congress_api.Models;
using MediatR;

namespace congress_api.Commands
{
    public class AddRepresentativeCommand : IRequest<string>
    {
        public ReprCamaraAlta Representante { get; }

        public AddRepresentativeCommand(ReprCamaraAlta representante)
        {
            this.Representante = representante;
        }
    }
}
