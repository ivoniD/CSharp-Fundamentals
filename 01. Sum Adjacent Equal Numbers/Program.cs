using System;
using System.Collections.Generic;
using System.Linq;

namespace P01._Sum_Adjacent_Equal_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToList();

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    numbers[i] = numbers[i] + numbers[i - 1];
                    numbers.RemoveAt(i - 1);
                    i = i - i;
                }
            }
            Console.WriteLine(string.Join(' ', numbers));

        }
    }
}
