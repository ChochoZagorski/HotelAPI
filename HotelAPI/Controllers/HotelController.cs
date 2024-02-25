using HotelAPI.Models;
using HotelAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.Controllers
{
    [Route("api/hotel")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelService hotelService;

        public HotelController(IHotelService hotelService)
        {
            this.hotelService = hotelService;
        }

        [HttpGet("GetHotels")]
        public IEnumerable<Hotel> Get()
        {
            return hotelService.GetHotels();
        }       

        [HttpPost("Create")]
        public void Create([FromBody] CreateHotelRequest createRequest)
        {
            hotelService.CreateHotel(createRequest);
        }

        [HttpDelete("Delete")]
        public void Delete(string id)
        {
            hotelService.DeleteHotel(id);
        }
        [HttpPut("Edit")]
        public void Edit([FromBody] Hotel hotel)
        {
            hotelService.EditHotel(hotel);
        }
    }
}
