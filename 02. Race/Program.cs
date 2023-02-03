using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P02_Race_REGEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine().Split(", ").ToList();

            Dictionary<string, int> raceInfo = new Dictionary<string, int>();

            foreach (var item in participants)
            {
                raceInfo.Add(item, 0);
            }

            string namePattern = "[A-Za-z]";
            string digitpattern = "[0-9]";

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string currName = string.Empty;
                string digit = string.Empty;
                MatchCollection mathchedLetters = Regex.Matches(input, namePattern);
                MatchCollection mathchedDigits = Regex.Matches(input, digitpattern);

                currName = string.Join("", mathchedLetters);
                digit = string.Join("", mathchedDigits);
                int currDigit = 0;
                foreach (char ch in digit)
                {
                    currDigit += (int)Char.GetNumericValue(ch);
                }
                if (!participants.Contains(currName))
                {
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    if (raceInfo.ContainsKey(currName))
                    {
                        raceInfo[currName] += currDigit;
                    }
                }

                input = Console.ReadLine();
            }

            string[] result = raceInfo.OrderByDescending(x => x.Value).Take(3).Select(x => x.Key).ToArray();
            Console.WriteLine($"1st place: {result[0]}");
            Console.WriteLine($"2nd place: {result[1]}");
            Console.WriteLine($"3rd place: {result[2]}");

        }
    }
}
