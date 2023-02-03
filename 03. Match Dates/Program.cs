using System;
using System.Text.RegularExpressions;

namespace P03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"([\d+]{2})(.|-|\/)([A-Z][a-z]{2})(\k<2>)([\d+]{4})";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                string day = match.Groups[1].Value;
                string month = match.Groups[3].Value;
                string year = match.Groups[5].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
