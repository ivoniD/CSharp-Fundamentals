using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToList();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandType = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string firstCommand = commandType[0];

                if (firstCommand == "Delete")
                {
                    int number = int.Parse(commandType[1]);
                    numbers.RemoveAll(x => x == number);
                }
                else if (firstCommand == "Insert")
                {
                    int number = int.Parse(commandType[1]);
                    int index = int.Parse(commandType[2]);
                    numbers.Insert(index, number);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
