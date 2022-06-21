using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaKata
{
    
    public class Tier : ITier
    {
        private List<Seat> seatingList = new();
        private List<char> rowIdentifiers = new();
        int NumRows { get; set; }
        int SeatsPerRow { get; set; }

        public Tier(int numRows, int seatsPerRow)
        {
            NumRows = numRows;
            SeatsPerRow = seatsPerRow;

  
        }

        public void SetRowIdentifier(char lowerCode)
        {
   
            for (int row = 0; row <= NumRows; row++)
            {
                rowIdentifiers.Add((char)((int)lowerCode+row));
            }

                
        }

        public List<Seat> CreateTier()
        {
            for (int row = 1; row <= NumRows; row++)
            {
                for (int seatNum = 1; seatNum <= SeatsPerRow; seatNum++)
                {
                    try 
                    {
                        char rowID = rowIdentifiers[row - 1];
                        seatingList.Add(new Seat(row, rowID, seatNum));
                    }
                    catch (Exception ex)
                    { 
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Have you set row identifiers ?");
                        
                    }
    

                    
                }
            }

            return seatingList;
        }

        public List<Seat> AllocateSeats(int numSeats)
        {
            List<Seat> newlyAllocatedSeats = new();
            int startIndex = seatingList.FindIndex(0, seat => seat.Allocated == false);

            if (startIndex == -1)
                Console.WriteLine($"Sorry, there are no more seats available");

            else if (numSeats > seatingList.Count-startIndex)
            {
                Console.WriteLine($"Sorry, only {seatingList.Count - startIndex} seats available");
            }
            else 
            { 
                for(int i = startIndex; i < (startIndex + numSeats); i++)
                {
     
                    newlyAllocatedSeats.Add(seatingList[i]);
                    seatingList[i].Allocated = true;
                }
            }
            return newlyAllocatedSeats;
        }
    }
}
