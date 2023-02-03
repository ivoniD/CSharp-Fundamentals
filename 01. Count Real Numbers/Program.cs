using System;
using System.Collections.Generic;
using System.Linq;

namespace P01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(num => int.Parse(num)).ToArray();

            SortedDictionary<int, int> count = new SortedDictionary<int, int>();

            foreach (int number in numbers)
            {
                if (count.ContainsKey(number))
                {
                    count[number]++;
                }
                else
                {
                    count.Add(number, 1);
                }

            }

            foreach (var item in count)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
