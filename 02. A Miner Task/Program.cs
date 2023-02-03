using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Mine = new Dictionary<string, int>();

            string commandKey = Console.ReadLine();

            while (commandKey != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!Mine.ContainsKey(commandKey))
                {
                    //Mine.Add(commandKey, quantity); 
                    //Mine[commandKey] = quantity;
                    Mine[commandKey] = 0;
                }

                Mine[commandKey] += quantity;

                commandKey = Console.ReadLine();
            }

            foreach (var res in Mine)
            {
                Console.WriteLine($"{res.Key} -> {res.Value}");
            }

        }
    }
}
