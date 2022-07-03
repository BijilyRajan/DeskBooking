using DeskBooking.Core.Model;
using System;

namespace DeskBooking.Core.Processor
{
    public class DeskbookingProcessor
    {
        public DeskbookingProcessor()
        {
        }

        public  DeskBookingResult BookDesk(DeskBookingRequest request)
        {
            return new DeskBookingResult
            {
                FirstName = request.FirstName,
                Email = request.Email,
                Date = request.Date
            };
        }
    }
}