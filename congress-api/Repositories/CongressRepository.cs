using congress_api.Models;
using Microsoft.EntityFrameworkCore;

namespace congress_api.Repositories
{
    public class CongressRepository : ICongressRepository
    {
        private readonly CongressDbContext _context;

        public CongressRepository(CongressDbContext context)
        {
            _context = context;
        }

        public async Task<List<SenadoresVigentes>> GetSenadores()
        {
            return await _context.SenadoresVigentes.ToListAsync();
        }

        public async Task<string> AddSenador(SenadoresVigentes representative)
        {
            _context.SenadoresVigentes.Add(representative);
            await _context.SaveChangesAsync();

            return representative.Id;
        }

        public async Task<List<DiputadosVigentes>> GetDiputados()
        {
            return await _context.DiputadosVigentes.ToListAsync();
        }
    }
}
