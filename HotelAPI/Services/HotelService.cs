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
        public bool DeleteHotel(string id)
        {
            var hotel = dbContext.Hotels.Find(id);

            if (hotel == null)
            {
                return false;
            }

            dbContext.Hotels.Remove(hotel!);
            dbContext.SaveChanges();

            return true;
        }

        public IEnumerable<Hotel> GetHotels()
        {
            return dbContext.Hotels.ToList();
        }
    }
}
