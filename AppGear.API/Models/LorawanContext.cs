using System.Collections.Immutable;
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
        public DbSet<LoriotDevice> LoriotDevices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoriotDevice>().HasData(
                new LoriotDevice
                {
                    DEV_ID = "MMD1001001991",
                    PCB_ID = "MMP1601003746",
                    DEV_EUI = "0004A30B0007D5C5",
                    APP_EUI = "050600000000FFFF",
                    APP_KEY = "0004A30B0007D5C588A783A1A7A0E3A1"
                },
                new LoriotDevice
                {
                    DEV_ID = "MMD1001001992",
                    PCB_ID = "MMP1601003747",
                    DEV_EUI = "0004A30B0007932B",
                    APP_EUI = "050600000000FFFF",
                    APP_KEY = "0004A30B0007932B88A783A1A7A0E3A1"
                },
                new LoriotDevice
                {
                    DEV_ID = "MMD1001001993",
                    PCB_ID = "MMP1601003748",
                    DEV_EUI = "0004A30B0007C3BE",
                    APP_EUI = "050600000000FFFF",
                    APP_KEY = "0004A30B0007C3BE88A783A1A7A0E3A1"
                },
                new LoriotDevice
                {
                    DEV_ID = "MMD1001001994",
                    PCB_ID = "MMP1601003749",
                    DEV_EUI = "0004A30B0007FE07",
                    APP_EUI = "050600000000FFFF",
                    APP_KEY = "0004A30B0007FE0788A783A1A7A0E3A1"
                }
            );
        }
    }
}