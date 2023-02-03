using System;
using System.Collections.Generic;

namespace P02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            Dictionary<string, int> occurrences = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string wordInLowerCase = word.ToLower();
                if (occurrences.ContainsKey(wordInLowerCase))
                {
                    occurrences[wordInLowerCase]++;
                }
                else
                {
                    occurrences.Add(wordInLowerCase, 1);
                }
            }

            foreach (var item in occurrences)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }
    }
}
