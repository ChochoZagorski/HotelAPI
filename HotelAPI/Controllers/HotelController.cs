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
        public void Get(string id)
        {

        }
    }
}
