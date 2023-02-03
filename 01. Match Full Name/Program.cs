using System;
using System.Text.RegularExpressions;

namespace regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.Write(match.Value + " ");
            }
        }
    }
}
