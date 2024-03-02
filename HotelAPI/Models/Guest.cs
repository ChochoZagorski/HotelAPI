using System.Diagnostics.Metrics;
using System.Reflection;
using System.Xml.Linq;

namespace HotelAPI.Models
{
    public class Guest
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age {get; set; }
        public char Gender { get; set; }
        public string Nationality { get; set; }

        public Guest()
        {
            
        }

        public Guest(CreateGuestRequest createRequest)
        {
            Id = Guid.NewGuid().ToString();
            FirstName = createRequest.FirstName;
            LastName = createRequest.LastName;
            Age = createRequest.Age;
            Gender = createRequest.Gender;
            Nationality = createRequest.Nationality;
        }
    }
}
