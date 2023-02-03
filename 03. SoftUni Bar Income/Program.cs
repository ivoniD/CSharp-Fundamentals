using System;
using System.Text.RegularExpressions;

namespace P03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"\%([A-Z]{1}[a-z]+)\%[^%$|.]*?\<(\w+)\>[^%$|.]*?\|(\d+)\|[^%$|.]*?(\d+(\.\d+)?)\$";


            string input = Console.ReadLine(); //%George%<Croissant>|2|10.3$
            double totalPrice = 0;

            while (input != "end of shift")
            {
                Match matchproduct = Regex.Match(input, pattern);

                if (matchproduct.Success)
                {
                    string name = matchproduct.Groups[1].Value;
                    string product = matchproduct.Groups[2].Value;
                    int count = int.Parse(matchproduct.Groups[3].Value);
                    double price = double.Parse(matchproduct.Groups[4].Value);

                    Console.WriteLine($"{name}: {product} - {(count * price):f2}");
                    totalPrice += count * price;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalPrice:f2}");

        }
    }
}
