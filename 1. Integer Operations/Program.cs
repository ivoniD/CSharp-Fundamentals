using System;

namespace _1._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            //•	Add first to the second.
            //•	Divide(integer) the result of the first operation by the third number.
            //•	Multiply the result of the second operation by the fourth number.
            int result = ((a + b) / c) * d;
            Console.WriteLine(result);
        }
    }
}
