namespace HotelAPI.Models
{
    public class CreateGuestRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public string Nationality { get; set; }
    }
}
