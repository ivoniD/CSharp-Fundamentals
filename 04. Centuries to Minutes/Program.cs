using System;

namespace _04._Centuries_to_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Use appropriate data types to fit the result after each data conversion.
            //•	Assume that a year has 365.2422 days on average(the Tropical year).
            //1 centuries = 100 years = 36524 days = 876576   hours = 52594560 minutes

            byte centuries = byte.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int) (years * 365.2422);
            int hours = days * 24;
           int minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
                

        }
    }
}
