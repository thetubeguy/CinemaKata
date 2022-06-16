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
    }
}
