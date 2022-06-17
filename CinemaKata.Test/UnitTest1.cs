using NUnit.Framework;
using System.Collections.Generic;
using FluentAssertions;

namespace CinemaKata.Test
{
    public class Tests
    {
        Tier TestTier;
        List<Seat> TestSeatingList;

        [SetUp]
        public void Setup()
        {

            
            TestTier = new(3, 5);
            TestTier.SetRowIdentifier(65, 69);
            TestSeatingList = TestTier.CreateTier();

           
           
        }

        [Test]
        public void CheckSeatingListIsConstructedInCorrectOrder()
        {

            TestSeatingList[0].Row.Should().Be(1);
            TestSeatingList[0].SeatNum.Should().Be(1);
            TestSeatingList[0].Allocated.Should().Be(false);
            TestSeatingList[4].Row.Should().Be(1);
            TestSeatingList[4].SeatNum.Should().Be(5);
            TestSeatingList[5].Row.Should().Be(2);
            TestSeatingList[5].SeatNum.Should().Be(1);
            TestSeatingList[10].Row.Should().Be(3);
            TestSeatingList[14].SeatNum.Should().Be(5);
        }

        [Test]
        public void GetSeatRequest_Should_Return_Random_Number_In_Range_1_To_3()
        {
            int numSeatsRequested = SeatRequest.GetSeatRequest();

            numSeatsRequested.Should().BeInRange(1, 3);
        }

        [Test]
        public void Allocating_2_Seats_Should_Return_The_First_2_Seats_On_Row_1()
        {
          
            List<Seat> seatsAllocated = TestTier.AllocateSeats(2);

            seatsAllocated.Count.Should().Be(2);    

            seatsAllocated[0].Row.Should().Be(1);
            seatsAllocated[0].SeatNum.Should().Be(1);
            seatsAllocated[0].Allocated.Should().Be(true);
            seatsAllocated[1].Row.Should().Be(1);
            seatsAllocated[1].SeatNum.Should().Be(2);
            seatsAllocated[1].Allocated.Should().Be(true);
        }
        [Test]
        public void Allocating_3_Seats_Should_Return_Seats_3_4_5_On_Row_1()
        {
            List<Seat> seatsAllocated = TestTier.AllocateSeats(2);
            seatsAllocated = TestTier.AllocateSeats(3);

            seatsAllocated.Count.Should().Be(3);

            seatsAllocated[0].Row.Should().Be(1);
            seatsAllocated[0].SeatNum.Should().Be(3);
            seatsAllocated[0].Allocated.Should().Be(true);
            seatsAllocated[1].Row.Should().Be(1);
            seatsAllocated[1].SeatNum.Should().Be(4);
            seatsAllocated[1].Allocated.Should().Be(true);
            seatsAllocated[2].Row.Should().Be(1);
            seatsAllocated[2].RowID.Should().Be('A');
            seatsAllocated[2].SeatNum.Should().Be(5);
            seatsAllocated[2].Allocated.Should().Be(true);
        }

    
     
 
    }
}