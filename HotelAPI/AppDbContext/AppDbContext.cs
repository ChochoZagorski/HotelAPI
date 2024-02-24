using HotelAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelAPI.MyAppDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            :base(options)
        {
            
        }

        public DbSet<Hotel> Hotels { get; set; }
    }
}
