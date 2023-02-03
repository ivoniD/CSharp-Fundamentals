using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P04._Star_Enigma_NEWW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> attackedPlanet = new List<string>();
            List<string> destroiedPlanets = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string encryptedMessage = Console.ReadLine();
                string decrMessage = string.Empty;
                string pattern = @"[STARstar]";
                MatchCollection matches = Regex.Matches(encryptedMessage, pattern);
                int starCount = matches.Count;

                foreach (Char ch in encryptedMessage) // STCDoghudd4=63333$D$0A53333
                {
                    int asciiValueOfCurrChar = (int)ch;
                    int decriptedValueOfCurrChar = asciiValueOfCurrChar - starCount;
                    char decrChar = (char)decriptedValueOfCurrChar;
                    decrMessage += decrChar.ToString(); // PQ@Alderaa1:30000!A!->2000    
                }

                string patternPlanets = @"[^@\-!:>]*@([A-Za-z]+)[^@\-!:>]*:(\d+)[^@\-!:>]*!(D|A{1})![^@\-!:>]*\->([\d]+)";
                Match match = Regex.Match(decrMessage, patternPlanets);

                if (match.Success)
                {
                    string planetName = match.Groups[1].Value;
                    int population = int.Parse(match.Groups[2].Value);
                    char attackType = char.Parse(match.Groups[3].Value);
                    int soliderCount = int.Parse(match.Groups[4].Value);
                    if (attackType == 'A')
                    {
                        attackedPlanet.Add(planetName);
                    }
                    else
                    {
                        destroiedPlanets.Add(planetName);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanet.Count}");
            foreach (string str in attackedPlanet.OrderBy(x => x))
            {
                Console.WriteLine($"-> {str}");
            }

            Console.WriteLine($"Destroyed planets: {destroiedPlanets.Count}");
            foreach (string str in destroiedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {str}");
            }
        }
    }
}
