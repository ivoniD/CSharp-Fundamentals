using System;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int currentNum = i;
                int currentSum = 0;

                while (currentNum != 0)
                {
                    currentSum += currentNum % 10;
                    currentNum = currentNum / 10;
                }
                bool special = (currentSum == 5) || (currentSum == 7) || (currentSum == 11);

                Console.WriteLine($"{i} -> {special}");
            }
        }
    }
}