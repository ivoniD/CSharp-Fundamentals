using System;
using System.Collections.Generic;
using System.Linq;

namespace _7list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 2 3 | 4 5 6 | 7  8

            string[] input = Console.ReadLine().Split('|', ' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> newOrder = new List<string>();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                string[] inputArgs = input[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                foreach (string inp in inputArgs)
                {
                    newOrder.Add(inp);
                }
            }
            Console.WriteLine(String.Join(' ', newOrder));
        }
    }
}
