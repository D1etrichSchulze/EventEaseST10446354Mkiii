using System.ComponentModel.DataAnnotations;

namespace EventEaseST10446354Mkiii.Models
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }
        public DateTime BookingDate { get; set; }

        // Foreign keys
        public int EventID { get; set; }
        public int VenueID { get; set; }

        // Navigation properties (singular)
        public Event? Event { get; set; }
        public Venue? Venue { get; set; }
    }
}
