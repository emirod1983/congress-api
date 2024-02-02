using congress_api.Models;

namespace congress_api.Repositories
{
    public interface ICongressRepository
    {
        Task<List<SenadoresVigentes>> GetSenadores();
        Task<string> AddSenador(SenadoresVigentes representative);
        Task<List<DiputadosVigentes>> GetDiputados();
    }
}
