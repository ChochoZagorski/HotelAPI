using HotelAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.Controllers
{
    [Route("api/hotel")]
    [ApiController]
    public class HotelController : ControllerBase
    {

        [HttpGet("GetHotel")]
        public Hotel Get(string id)
        {
            return new Hotel { Id = id };
        }

        [HttpGet("GetHotelByName")]
        public Hotel GetName(string name)
        {
            return new Hotel { Name = name };
        }
    }
}
