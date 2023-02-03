using System;
using System.Collections.Generic;
using System.Linq;

namespace P06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();
            //•	Add {number}: add a number to the end of the list.
            //•	Remove { number}: remove a number from the list.
            //•	RemoveAt { index}: remove a number at a given index.
            //•	Insert { number}{ index}: insert a number at a given index.

            while (command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    int number = int.Parse(command[1]);
                    numbers.Add(number);
                }
                else if (command[0] == "Remove")
                {
                    int number = int.Parse(command[1]);
                    numbers.Remove(number);
                }
                else if (command[0] == "RemoveAt")
                {
                    int index = int.Parse(command[1]);
                    numbers.RemoveAt(index);
                }
                else if (command[0] == "Insert")
                {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    numbers.Insert(index, number);
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
