using congress_api.Models;
using MediatR;

namespace congress_api.Queries
{
    public class GetRepresentantesCamaraBajaQuery : IRequest<List<DiputadosVigentes>>
    {
    }
}
