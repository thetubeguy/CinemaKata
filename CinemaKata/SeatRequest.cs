using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaKata
{
    public class SeatRequest : ISeatRequest
    {
        public int GetSeatRequest()
        {
            Random random = new ();
            return random.Next(3)+1;
        }
    }
}
