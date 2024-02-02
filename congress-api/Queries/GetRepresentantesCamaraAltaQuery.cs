using congress_api.Models;
using MediatR;

namespace congress_api.Queries
{
    public class GetRepresentantesCamaraAltaQuery : IRequest<List<SenadoresVigentes>>
    {
    }
}
