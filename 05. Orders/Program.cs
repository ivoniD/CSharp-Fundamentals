using System;

namespace P05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            price(product, quantity);
        }

        static void price(string product, int quantity)
        {
            double price = 0;
            if (product == "coffee")
            {
                price = 1.50;
            }

            else if (product == "water")
            {
                price = 1.00;
            }

            else if (product == "coke")
            {
                price = 1.40;
            }

            else if (product == "snacks")
            {
                price = 2.00;
            }

            double total = price * quantity;
            Console.WriteLine($"{total:f2}");
        }
    }
}
