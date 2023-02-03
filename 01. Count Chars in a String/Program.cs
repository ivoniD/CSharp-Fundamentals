using System;
using System.Collections.Generic;

namespace P01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray(); // t e x t

            Dictionary<char, int> lettersDic = new Dictionary<char, int>(); // - - -

            foreach (char letter in word) // t e x t
            {
                if (letter != ' ')
                {
                    if (!lettersDic.ContainsKey(letter))
                    {
                        lettersDic.Add(letter, 0);
                        // lettersDic[letter] = 0;
                    }
                    lettersDic[letter]++;
                }
            }

            foreach (var letter in lettersDic)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
