using HotelAPI.Models;
using HotelAPI.MyAppDbContext;

namespace HotelAPI.Services
{
    public class HotelService : IHotelService
    {
        private readonly AppDbContext dbContext;

        public HotelService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool CreateHotel(Hotel hotel)
        {
            dbContext.Hotels.Add(hotel);
            dbContext.SaveChanges();

            return true;
        }

        public IEnumerable<Hotel> GetHotels()
        {
            return dbContext.Hotels.ToList();
        }
    }
}
