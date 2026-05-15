using System;

namespace HairSalon.Core.Entities
{
    public class TimeSlot
    {
        public int Id { get; set; }
        public string SlotTime { get; set; } // e.g., "09:00", "09:30"
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; }
    }
}
