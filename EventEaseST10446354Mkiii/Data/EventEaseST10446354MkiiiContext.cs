using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventEaseST10446354Mkiii.Models;

namespace EventEaseST10446354Mkiii.Data
{
    public class EventEaseST10446354MkiiiContext : DbContext
    {
        public EventEaseST10446354MkiiiContext (DbContextOptions<EventEaseST10446354MkiiiContext> options)
            : base(options)
        {
        }

        public DbSet<EventEaseST10446354Mkiii.Models.Venue> Venue { get; set; } = default!;
        public DbSet<EventEaseST10446354Mkiii.Models.Event> Event { get; set; } = default!;
        public DbSet<EventEaseST10446354Mkiii.Models.Booking> Booking { get; set; } = default!;
    }
}
