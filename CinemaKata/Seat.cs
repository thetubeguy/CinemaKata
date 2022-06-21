using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaKata
{
    public class Seat
    {
        public int Row { get; private set; }
        public int SeatNum { get; private set; }

        public bool Allocated {get; set; }
        public char RowID {get; private set; }  

        public Seat(int row, char rowID, int seatnum)
        {
            Row = row;
            RowID = rowID;
            SeatNum = seatnum;
            Allocated = false;
        }

 
    }
}
