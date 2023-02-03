using System;
using System.Collections.Generic;

namespace P06._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            while (command != "end")
            {
                string[] cmdArgs = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = cmdArgs[0];
                string studentName = cmdArgs[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }
                courses[courseName].Add(studentName);
                command = Console.ReadLine();
            }

            foreach (var kvp in courses)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
