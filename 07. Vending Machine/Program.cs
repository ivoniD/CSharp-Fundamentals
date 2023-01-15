using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;
            //•	0.1, 0.2, 0.5, 1, and 2
            while (input != "Start")
            {
                if (input == "0.1" || input == "0.2" || input == "0.5" || input == "1" || input == "2")
                {
                    sum += double.Parse(input);

                }
                else
                {
                    Console.WriteLine($"Cannot accept {input}");

                }
                input = Console.ReadLine();
            }

            string product = Console.ReadLine();
            double prodPrice = 0;
            // Nuts" with a price of 2.0
            //	"Water" with a price of 0.7
            //	"Crisps" with a price of 1.5
            //	"Soda" with a price of 0.8
            //	"Coke" with a price of 1.0

            while (product != "End")
            {
                if (product == "Nuts")
                {
                    prodPrice = 2.0;
                }
                else if (product == "Water")
                {
                    prodPrice = 0.7;
                }
                else if (product == "Crisps")
                {
                    prodPrice = 1.5;
                }
                else if (product == "Soda")
                {
                    prodPrice = 0.8;
                }
                else if (product == "Coke")
                {
                    prodPrice = 1.0;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    product = Console.ReadLine();
                    continue;
                }

                if (prodPrice <= sum /*&& sum > 0 && prodPrice > 0*/)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    sum = sum - prodPrice;
                }
                else if (prodPrice > sum)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                product = Console.ReadLine();
            }
            if (product == "End")
            {

                Console.WriteLine($"Change: {sum:f2}");
            }
        }
    }
}
