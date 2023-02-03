using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @">>([A-Za-z]+)<<(\d+(\.\d+)?)\!(\d+)\b";

            decimal totalMoney = 0m;

            List<string> furniture = new List<string>();

            while (input != "Purchase")
            {
                MatchCollection matches = Regex.Matches(input, pattern);

                foreach (Match match in matches)
                {
                    string currFurniture = match.Groups[1].Value;
                    furniture.Add(currFurniture);
                    decimal currPrice = decimal.Parse(match.Groups[2].Value);
                    int quantity = int.Parse(match.Groups[4].Value);

                    totalMoney += currPrice * (decimal)quantity;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            foreach (var item in furniture)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {totalMoney:f2}");
        }
    }
}
