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

        public async Task<List<ReprCamaraAlta>> GetSenadores()
        {
            return await _context.ReprCamaraAlta.ToListAsync();
        }

        public async Task<string> AddSenador(ReprCamaraAlta representative)
        {
            _context.ReprCamaraAlta.Add(representative);
            await _context.SaveChangesAsync();

            return representative.Id;
        }

        public async Task<List<ReprCamaraBaja>> GetDiputados()
        {
            return await _context.ReprCamaraBaja.ToListAsync();
        }
    }
}
