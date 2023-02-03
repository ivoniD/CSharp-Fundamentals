using System;
using System.Collections.Generic;
using System.Linq;

namespace P04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string toDo = cmdArgs[0];

                if (toDo == "Add")
                {
                    int num = int.Parse(cmdArgs[1]);
                    numbers.Add(num);
                }
                else if (toDo == "Insert")
                {
                    int num = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);
                    if (index > numbers.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, num);
                    }

                }
                else if (toDo == "Remove")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (index > numbers.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                }
                else if (toDo == "Shift")
                {
                    string direction = cmdArgs[1];

                    if (direction == "left")
                    {
                        int count = int.Parse(cmdArgs[2]);
                        int realCount = count % numbers.Count;
                        for (int i = 0; i < realCount; i++)
                        {
                            int firstnumber = numbers[0];
                            // int firstnum = numbers.First();
                            numbers.RemoveAt(0);
                            numbers.Add(firstnumber);
                        }
                    }
                    else if (direction == "right")
                    {
                        int count = int.Parse(cmdArgs[2]);
                        int realCount = count % numbers.Count;
                        for (int i = 0; i < realCount; i++)
                        {
                            int lastnumber = numbers[numbers.Count - 1];
                            // int lastnum = numbers.Last();
                            numbers.RemoveAt(numbers.Count - 1);
                            numbers.Insert(0, lastnumber);
                        }
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
