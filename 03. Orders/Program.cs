using System;
using System.Collections.Generic;

namespace P04._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> orders = new Dictionary<string, double>();
            Dictionary<string, int> ordersQuantity = new Dictionary<string, int>();
            double totalPrice = 0;
            string command = Console.ReadLine(); //Beer   2.20   100
            while (command != "buy")            //  0      1      2         
            {
                string[] cmdArgs = command.Split(' ');
                string product = cmdArgs[0];
                double price = double.Parse(cmdArgs[1]);
                int quantity = int.Parse(cmdArgs[2]);

                if (!orders.ContainsKey(product))
                {
                    orders[product] = price;
                    ordersQuantity.Add(product, quantity);
                }
                else
                {
                    ordersQuantity[product] += quantity;
                    orders[product] = price;
                }


                command = Console.ReadLine();
            }

            foreach (var item in orders)
            {
                foreach (var item2 in ordersQuantity)
                {
                    totalPrice = item.Value * item2.Value;
                    Console.WriteLine($"{item.Key} -> {totalPrice:f2}");
                    ordersQuantity.Remove(item2.Key);
                    break;
                }

            }

        }
    }
}
