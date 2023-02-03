using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfCommands = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();
            for (int i = 1; i <= numOfCommands; i++)
            {
                string[] cmdArg = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (cmdArg.Length == 3)
                {
                    string name = cmdArg[0];
                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guests.Add(name);
                    }
                }
                else if (cmdArg.Length == 4)
                {
                    string name = cmdArg[0];
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
            foreach (string str in guests)
            {
                Console.WriteLine(str);
            }
        }
    }
}
