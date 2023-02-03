using System;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> newList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                newList.Add(input);
            }
            newList.Sort();
            for (int i = 0; i < newList.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{newList[i]}");
            }
        }
    }
}
