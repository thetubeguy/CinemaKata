using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaKata
{
    public class Seat
    {
        public int Row { get; set; }
        public int SeatNum { get; set; }

        public bool Allocated {get; set; }

        public Seat(int row, int seatnum)
        {
            Row = row;
            SeatNum = seatnum;
            Allocated = false;
        }
    }
}
