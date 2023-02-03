using System;
using System.Text.RegularExpressions;

namespace P02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\+359(\s|-)2(\k<1>)[\d+]{3}(\k<1>)[\d+]{4}\b";

            MatchCollection matches = Regex.Matches(input, pattern);

            Console.WriteLine(string.Join(", ", matches));



        }
    }
}
