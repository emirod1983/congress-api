using Microsoft.EntityFrameworkCore;

namespace congress_api.Models
{
    public class CongressDbContext : DbContext
    {
        public CongressDbContext(DbContextOptions<CongressDbContext> options)
            : base(options)
        {
        }

        public DbSet<SenadoresVigentes> SenadoresVigentes { get; set; }
        public DbSet<DiputadosVigentes> DiputadosVigentes { get; set; }
    }
}
