using HotelAPI.Models;
using HotelAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.Controllers
{
    [Route("api/guest")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService guestService;

        public GuestController(IGuestService guestService)
        {
            this.guestService = guestService;
        }

        [HttpGet("GetGuests")]
        public IEnumerable<Guest> Get()
        {
            return guestService.GetGuests();
        }

        [HttpPost("Create")]
        public void Create([FromBody] CreateGuestRequest createRequest)
        {
            guestService.CreateGuest(createRequest);
        }

        [HttpDelete("Delete")]
        public void Delete(string id)
        {
            guestService.DeleteGuest(id);
        }
        [HttpPut("Edit")]
        public void Edit([FromBody] Guest guest)
        {
            guestService.EditGuest(guest);
        }
    }
}
