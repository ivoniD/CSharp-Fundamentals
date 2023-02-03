using System;
using System.Collections.Generic;

namespace P08._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();

            while (command != "End")
            {
                string[] cmdArgs = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string companyName = cmdArgs[0];
                string employeeId = cmdArgs[1];

                if (!users.ContainsKey(companyName))
                {
                    users.Add(companyName, new List<string>());
                }
                if (!users[companyName].Contains(employeeId))
                {
                    users[companyName].Add(employeeId);
                }

                command = Console.ReadLine();
            }

            foreach (var kvp in users)
            {
                Console.WriteLine(kvp.Key);
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
