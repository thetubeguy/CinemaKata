using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaKata
{
    public interface ITier
    {
        void SetRowIdentifier(char lowerCode);
        List<Seat> AllocateSeats(int numSeats);
    }
}
