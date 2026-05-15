using System;

namespace HairSalon.Core.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime AddedAt { get; set; }

        // Navigation properties
        public User User { get; set; }
        public Product Product { get; set; }
    }
}
