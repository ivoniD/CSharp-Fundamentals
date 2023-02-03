using System;

namespace P__Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Enter a number in range 1-7 and print out the word representing it or "Invalid Day!".
            //Use an array of strings.

            string[] daysOfWeek = new string[]
            {"Monday", "Tuesday", "WednesDay", "Thursday", "Friday", "Saturday", "Sunday"};

            int number = int.Parse(Console.ReadLine());

            if (number > 0 && number <= 7)
            {
                Console.WriteLine(daysOfWeek[number - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
