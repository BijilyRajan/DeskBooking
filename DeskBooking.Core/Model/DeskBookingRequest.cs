using System;

namespace DeskBooking.Core.Model
{
    public class DeskBookingRequest
    {
        public string FirstName { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
    }
}