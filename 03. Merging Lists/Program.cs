using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 5 2 43 12 3 54 10 23
            //76 5 34 2 4 12

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numbers2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> newList = new List<int>();


            int maxList = Math.Max(numbers.Count, numbers2.Count);

            for (int i = 0; i < maxList; i++)
            {
                if (i <= numbers.Count - 1)
                {
                    newList.Add(numbers[i]);
                }
                if (i <= numbers2.Count - 1)
                {
                    newList.Add(numbers2[i]);
                }
            }
            Console.WriteLine(string.Join(" ", newList));
        }
    }
}
