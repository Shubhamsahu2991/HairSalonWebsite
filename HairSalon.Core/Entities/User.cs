using System;
using System.Collections.Generic;

namespace HairSalon.Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; } // Admin, Customer
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsActive { get; set; } = true;

        // Navigation properties
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<Cart> CartItems { get; set; } = new List<Cart>();
    }
}
