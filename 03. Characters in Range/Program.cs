using System;

namespace P03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());
            string charactersBetween = CharactersBetween(ch1, ch2);
            Console.WriteLine(charactersBetween);
        }
        static string CharactersBetween(char ch1, char ch2)
        {
            int charIndex1 = (int)ch1;
            int charIndex2 = (int)ch2;
            string letters = string.Empty;
            for (int i = charIndex1 + 1; i < charIndex2; i++)
            {
                letters += $"{(char)i} ";
            }
            if (charIndex2 < charIndex1)
            {
                for (int i = charIndex2 + 1; i < charIndex1; i++)
                {
                    letters += $"{(char)i} ";
                }
            }
            return letters;
        }
    }
}
