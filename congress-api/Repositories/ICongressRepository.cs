using congress_api.Models;

namespace congress_api.Repositories
{
    public interface ICongressRepository
    {
        Task<List<SenadoresVigentes>> GetSenadoresVigentes();
        Task<List<SenadoresHistoricos>> GetSenadoresHistoricos();
        Task<string> AddSenador(SenadoresVigentes representative);
        Task<List<DiputadosVigentes>> GetDiputados();
    }
}
