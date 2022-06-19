using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaKata
{
    public class SeatRequest
    {
        public static int GetSeatRequest()
        {
            Random random = new ();
            return random.Next(3)+1;
        }
    }
}
