using HotelAPI.Models;

namespace HotelAPI.Services
{
    public interface IHotelService
    {
        IEnumerable<Hotel> GetHotels();

        bool CreateHotel(CreateHotelRequest createRequest);

        bool DeleteHotel(string id);
    }
}
