using System;
namespace CafeExpresso.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int TotalGuests { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Time { get; set; }
    }
}
