using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace CinemaKata
{
    public class SeatRequestService : BackgroundService
    {

        private readonly ISeatRequest _seatRequest;

        public SeatRequestService(ISeatRequest seatRequest)
        {
            _seatRequest = seatRequest;

        }

        public int GetSeatRequest()
        {
            return _seatRequest.GetSeatRequest();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                Console.Write($"Worker running at: {DateTimeOffset.Now}");
                await Task.Delay(1000, stoppingToken);
            }

        }
    }
}

