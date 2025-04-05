using System.ComponentModel.DataAnnotations;

namespace EventEaseST10446354Mkiii.Models
{
    public class Venue
    {
        [Key]
        public int VenueID { get; set; }
        public string? VenueName { get; set; }
        public string? VenueLocation { get; set; }
        public string? Capacity { get; set; }

        public List<Booking>? Bookings { get; set; }
    }
}
