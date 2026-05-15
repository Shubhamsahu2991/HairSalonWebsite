using System;
using System.Collections.Generic;

namespace HairSalon.Core.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Duration { get; set; } // in minutes
        public string ImageUrl { get; set; }
        public string Category { get; set; } // Hair Cut, Coloring, Treatment, etc.
        public bool IsAvailable { get; set; } = true;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Navigation properties
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
