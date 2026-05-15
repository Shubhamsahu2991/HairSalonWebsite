using System;
using System.Collections.Generic;

namespace HairSalon.Core.Entities
{
    public class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public string ImageUrl { get; set; }
        public bool IsAvailable { get; set; } = true;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Navigation properties
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
