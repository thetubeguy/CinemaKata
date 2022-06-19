using CinemaKata;
using System;




int numRows = getInput<int>("Please enter the number of rows: ");
int seatsInRow = getInput<int>("Please enter the number of seats in a row: ");
char lowerCode = getInput<char>("Please enter the character to represent the first row: ");

Tier OneTier = new(numRows, seatsInRow);

OneTier.SetRowIdentifier(lowerCode);

dynamic getInput<T>(string message)
{
    while(true)
    {
        Console.Write(message);
        try
        {
            if (typeof(T) == typeof(int)) return Convert.ToInt32(Console.ReadLine());

            else if (typeof(T) == typeof(char)) return Convert.ToChar(Console.ReadLine());

            else throw new Exception("Type not supported");

        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message + " Please try again.");
            Console.WriteLine();
        }
    }

}





