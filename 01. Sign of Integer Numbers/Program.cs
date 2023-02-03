using System;

namespace _01._Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	For positive number: "The number {number} is positive."
            //•	For negative number: "The number {number} is negative."
            //•	For zero number: "The number {number} is zero."

            int num = int.Parse(Console.ReadLine());
            theNumberIs(num);
        }
        static void theNumberIs(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {num} is zero.");
            }

        }
    }
}
