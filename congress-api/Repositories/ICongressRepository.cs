using congress_api.Models;

namespace congress_api.Repositories
{
    public interface ICongressRepository
    {
        Task<List<ReprCamaraAlta>> GetSenadores();
        Task<string> AddSenador(ReprCamaraAlta representative);
        Task<List<ReprCamaraBaja>> GetDiputados();
    }
}
