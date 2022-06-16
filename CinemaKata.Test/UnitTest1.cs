using NUnit.Framework;
using System.Collections.Generic;
using FluentAssertions;

namespace CinemaKata.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CheckSeatingListIsConstructedInCorrectOrder()
        {
            Tier TestTier = new(3, 5);
            List<Seat> TestSeatingList;


            TestSeatingList = TestTier.CreateTier();

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
    }
}