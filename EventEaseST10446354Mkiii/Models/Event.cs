using System.ComponentModel.DataAnnotations;

namespace EventEaseST10446354Mkiii.Models
{
    public class Event
    {
        [Key]
        public int EventID { get; set; }
        public string? EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string? EventDescription { get; set; }

        public List<Booking>? Bookings { get; set; }
    }
}
