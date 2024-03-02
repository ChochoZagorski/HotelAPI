using HotelAPI.Models;
using HotelAPI.MyAppDbContext;

namespace HotelAPI.Services
{
    public class GuestService : IGuestService
    {
        private readonly AppDbContext dbContext;

        public GuestService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool CreateGuest(CreateGuestRequest createRequest)
        {
            var guest = new Guest(createRequest);

            dbContext.Guests.Add(guest);
            dbContext.SaveChanges();

            return true;
        }
        public bool DeleteGuest(string id)
        {
            var guest = dbContext.Guests.Find(id);

            if (guest == null)
            {
                return false;
            }

            dbContext.Guests.Remove(guest!);
            dbContext.SaveChanges();

            return true;
        }

        public bool EditGuest(Guest guest)
        {
            dbContext.Guests.Update(guest);
            dbContext.SaveChanges();
            return true;
        }

        public IEnumerable<Guest> GetGuests()
        {
            return dbContext.Guests.ToList();
        }
    }
}
