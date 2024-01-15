using Microsoft.EntityFrameworkCore;

namespace congress_api.Models
{
    public class CongressDbContext : DbContext
    {
        public CongressDbContext(DbContextOptions<CongressDbContext> options)
            : base(options)
        {
        }

        public DbSet<ReprCamaraAlta> ReprCamaraAlta { get; set; }
        public DbSet<ReprCamaraBaja> ReprCamaraBaja { get; set; }
    }
}
