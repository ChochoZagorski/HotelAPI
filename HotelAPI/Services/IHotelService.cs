using HotelAPI.Models;

namespace HotelAPI.Services
{
    public interface IHotelService
    {
        IEnumerable<Hotel> GetHotels();

        bool CreateHotel(Hotel hotel);
    }
}
