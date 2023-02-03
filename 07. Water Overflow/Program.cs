using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int lit = int.Parse(Console.ReadLine());
                if ((sum + lit) > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sum += lit;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
