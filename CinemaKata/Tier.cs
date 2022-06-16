using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaKata
{
    
    public class Tier
    {
        List<Seat> seatingList = new();
        int NumRows { get; set; }
        int SeatsPerRow { get; set; }

        public Tier(int numRows, int seatsPerRow)
        {
            NumRows = numRows;
            SeatsPerRow = seatsPerRow;

  
        }

        public List<Seat> CreateTier()
        {
            for (int row = 1; row <= NumRows; row++)
            {
                for (int seatNum = 1; seatNum <= SeatsPerRow; seatNum++)
                {
                    seatingList.Add(new Seat(row, seatNum));
                }
            }

            return seatingList;
        }

        public List<Seat> AllocateSeats(int numSeats)
        {
            List<Seat> newlyAllocatedSeats = new();
            int startIndex = seatingList.FindIndex(0, seat => seat.Allocated == false);

            for(int i = startIndex; i < (startIndex + numSeats); i++)
            {
                newlyAllocatedSeats.Add(seatingList[i]);
                seatingList[i].Allocated = true;
            }

            return newlyAllocatedSeats;
        }
    }
}
