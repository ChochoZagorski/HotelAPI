namespace HotelAPI.Models
{
    public class Hotel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public Hotel()
        {
            
        }

        public Hotel(CreateHotelRequest createRequest)
        {
            Id = Guid.NewGuid().ToString();
            Name = createRequest.Name;
            City = createRequest.City;
            Country = createRequest.Country;
        }
    }
}
