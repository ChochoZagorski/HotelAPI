using HotelAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace HotelAPI.MyAppDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            :base(options)
        {
            
        }

        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed initial data
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel { Id = Guid.NewGuid().ToString(), Name = "Hills" },
                new Hotel { Id = Guid.NewGuid().ToString(), Name = "Sofia" },
                new Hotel { Id = Guid.NewGuid().ToString(), Name = "Nexus" },
                new Hotel { Id = Guid.NewGuid().ToString(), Name = "Nessebar" }
                // Add more initial records as needed
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
