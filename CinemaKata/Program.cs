using CinemaKata;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;



using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
        services.AddScoped<ISeatRequest, SeatRequest>()
            .AddScoped<SeatRequestService>()).Build();
        

using IServiceScope serviceScope = host.Services.CreateScope();
IServiceProvider provider = serviceScope.ServiceProvider;
SeatRequestService request = provider.GetRequiredService<SeatRequestService>();

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
    numSeats = request.GetSeatRequest();
    Console.WriteLine($"Requesting {numSeats} seats.");
    seatsAllocated = OneTier.AllocateSeats(numSeats);

    foreach (Seat seat in seatsAllocated)
    {
        Console.WriteLine($"Allocated seat: {seat.RowID}{seat.SeatNum}");
    }

} while (seatsAllocated.Count > 0);  












