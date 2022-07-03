using System;

namespace DeskBooking.Core.Tests.Processor
{
    internal class DeskBookingRequest
    {
        public string FirstName { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
    }
}