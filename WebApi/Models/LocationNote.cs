namespace WebApi.Models
{
    public class LocationNote
    {
        public string Note { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }

        public LocationNote(string note, decimal longitude, decimal latitude)
        {
            Note = note;
            Longitude = longitude;
            Latitude = latitude;
        }
    }
}
