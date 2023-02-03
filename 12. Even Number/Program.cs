using System;

namespace _12._Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //"The number is: {number}", and terminate the program. If the number is odd, print "Please write an even number." 
            int n = int.Parse(Console.ReadLine());
            while (true)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(n)}");
                    return;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
                n = int.Parse(Console.ReadLine());
            }
        }
    }
}
