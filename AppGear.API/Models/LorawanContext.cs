using Microsoft.EntityFrameworkCore;

namespace AppGear.API.Models
{
    public class LorawanContext : DbContext
    {
        public LorawanContext(DbContextOptions<LorawanContext> options)
            : base(options)
        {
            
        }

        public DbSet<Lorawan> Lorawans { get; set; }
    }
}