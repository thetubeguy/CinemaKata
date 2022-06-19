using CinemaKata;
using System;


List<Seat>? seatsAllocated;

int numRows = InputValidation.getInput<int>("Please enter the number of rows: ");
int seatsInRow = InputValidation.getInput<int>("Please enter the number of seats in a row: ");
char lowerCode = InputValidation.getInput<char>("Please enter the character to represent the first row: ");

Tier OneTier = new(numRows, seatsInRow);

OneTier.SetRowIdentifier(lowerCode);

List<Seat> SeatingList = OneTier.CreateTier();

int numSeats;
do
{
    numSeats = SeatRequest.GetSeatRequest();
    Console.WriteLine($"Requesting {numSeats} seats.");
    seatsAllocated = OneTier.AllocateSeats(numSeats);

    foreach (Seat seat in seatsAllocated)
    {
        Console.WriteLine($"Allocated seat: {seat.RowID}{seat.SeatNum}");
    }

} while (seatsAllocated.Count > 0);









