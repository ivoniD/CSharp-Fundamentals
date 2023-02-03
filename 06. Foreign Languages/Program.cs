using System;

namespace _06._Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	English is spoken in England and the USA.
            //•	Spanish is spoken in Spain, Argentina, and Mexico.
            //•	For the others, we should print "unknown".
            // If the country is unknown for the program, print "unknown".
            string country = Console.ReadLine();

            if (country == "England" || country == "USA")
            {
                Console.WriteLine("English");
            }
            else if (country == "Spain" || country == "Argentina" || country == "Mexico")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
