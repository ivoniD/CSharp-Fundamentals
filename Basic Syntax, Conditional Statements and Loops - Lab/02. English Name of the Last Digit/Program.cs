using System;

namespace _02._English_Name_of_the_Last_Digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int x = num % 10;
            if (x == 0)
            {
                Console.WriteLine("zero");
            }
            else if (x == 1)
            {
                Console.WriteLine("one");
            }
            else if (x == 2)
            {
                Console.WriteLine("two");
            }
            else if (x == 3)
            {
                Console.WriteLine("three");
            }
            else if (x == 4)
            {
                Console.WriteLine("four");
            }
            else if (x == 5)
            {
                Console.WriteLine("five");
            }
            else if (x == 6)
            {
                Console.WriteLine("six");
            }
            else if (x == 7)
            {
                Console.WriteLine("seven");
            }
            else if (x == 8)
            {
                Console.WriteLine("eight");
            }
            else if (x == 9)
            {
                Console.WriteLine("nine");
            }
        }
    }
}
