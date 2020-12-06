using Microsoft.EntityFrameworkCore;

namespace AppGear.API.Models
{
    public class LorawanContext : DbContext
    {
        public LorawanContext(DbContextOptions<LorawanContext> options)
            : base(options)
        {
            
        }

        public DbSet<LoriotTest> LoriotsTest { get; set; }
        public DbSet<LoriotProduction> LoriotsProduction { get; set; }
        public DbSet<LoriotDecodeModel> LoriotDecoded { get; set; }
    }
}