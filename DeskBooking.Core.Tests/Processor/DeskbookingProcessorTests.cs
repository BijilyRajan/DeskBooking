using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DeskBooking.Core.Tests.Processor
{
    public class DeskbookingProcessorTests
    {
        [Fact]
        public void ShouldReturnValidResultForBookingRequest()
        {
            //Arrange
            var request = new DeskBookingRequest
            {
                FirstName = "Thomas",
                Email = "abc@xyc.com",
                Date = new DateTime(2020, 1, 1)
            };

            
            var processor = new DeskbookingProcessor();

            //Act
            DeskBookingResult result = processor.BookDesk(request);


            //Assert
            Assert.NotNull(result);
        }
    }
}
