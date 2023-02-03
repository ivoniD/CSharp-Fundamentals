using System;
using System.Collections.Generic;
using System.Linq;

namespace P01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            Random random = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                int randomPos = random.Next(words.Count);
                string temp = words[i];
                words[i] = words[randomPos];
                words[randomPos] = temp;
            }
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
