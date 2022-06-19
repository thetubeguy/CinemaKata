using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaKata
{
    public class InputValidation
    {
        public static dynamic getInput<T>(string message)
        {
            while (true)
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
    }
}
