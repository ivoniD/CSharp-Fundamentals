using System;

namespace _03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Name                        Price
            //OutFall 4                   $39.99
            //CS: OG                      $15.99
            //Zplinter Zell	              $19.99
            //Honored 2                   $59.99
            //RoverWatch                  $29.99
            //RoverWatch Origins Edition  $39.99
            double currBalance = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double price = 0;
            double totalspent = 0;
            while (input != "Game Time")
            {
                if (input == "OutFall 4" || input == "RoverWatch Origins Edition")
                {
                    price = 39.99;
                    if (price > currBalance)
                    {
                        Console.WriteLine("Too Expensive");
                        input = Console.ReadLine();
                        continue;
                    }
                    currBalance -= price;
                    totalspent += price;
                }
                else if (input == "CS: OG")
                {
                    price = 15.99;
                    if (price > currBalance)
                    {
                        Console.WriteLine("Too Expensive");
                        input = Console.ReadLine();
                        continue;
                    }
                    currBalance -= price;
                    totalspent += price;
                }
                else if (input == "Zplinter Zell")
                {
                    price = 19.99;
                    if (price > currBalance)
                    {
                        Console.WriteLine("Too Expensive");
                        input = Console.ReadLine();
                        continue;
                    }
                    currBalance -= price;
                    totalspent += price;
                }
                else if (input == "Honored 2")
                {
                    price = 59.99;
                    if (price > currBalance)
                    {
                        Console.WriteLine("Too Expensive");
                        input = Console.ReadLine();
                        continue;
                    }
                    currBalance -= price;
                    totalspent += price;
                }
                else if (input == "RoverWatch")
                {
                    price = 29.99;
                    if (price > currBalance)
                    {
                        Console.WriteLine("Too Expensive");
                        input = Console.ReadLine();
                        continue;
                    }
                    currBalance -= price;
                    totalspent += price;
                }
                else
                {
                    Console.WriteLine("Not Found");
                    input = Console.ReadLine();
                    continue;
                }
                Console.WriteLine($"Bought {input}");
                if (currBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "Game Time")
            {
                Console.WriteLine($"Total spent: ${totalspent:f2}. Remaining: ${currBalance:f2}");
            }
        }
    }
}
