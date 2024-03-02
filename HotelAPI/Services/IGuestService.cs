using HotelAPI.Models;

namespace HotelAPI.Services
{
    public interface IGuestService
    {
        IEnumerable<Guest> GetGuests();

        bool CreateGuest(CreateGuestRequest createRequest);

        bool DeleteGuest(string id);

        bool EditGuest(Guest guest);
    }
}
