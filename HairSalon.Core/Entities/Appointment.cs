using System;
using HairSalon.Core.Enums;

namespace HairSalon.Core.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ServiceId { get; set; }
        public int StaffId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string TimeSlot { get; set; } // e.g., "10:00 AM"
        public AppointmentStatus Status { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Navigation properties
        public User User { get; set; }
        public Service Service { get; set; }
        public Staff Staff { get; set; }
    }
}
