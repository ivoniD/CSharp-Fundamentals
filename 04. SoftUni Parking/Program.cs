using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> parking = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] cmdArg = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArg[0];


                if (command == "register")
                {
                    string username = cmdArg[1];
                    string licensePlateNumber = cmdArg[2];
                    if (!parking.ContainsKey(username))
                    {
                        parking[username] = licensePlateNumber;
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                        continue;
                    }
                }
                else if (command == "unregister")
                {
                    string username = cmdArg[1];
                    if (!parking.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        parking.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            foreach (var item in parking)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
