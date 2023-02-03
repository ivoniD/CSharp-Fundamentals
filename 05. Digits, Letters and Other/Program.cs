using System;

namespace digitLetterAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Agd#53Dfg^&4F53

            string input = Console.ReadLine();

            string digits = string.Empty;
            string letters = string.Empty;
            string other = string.Empty;

            foreach (char ch in input)
            {
                if (char.IsDigit(ch))
                {
                    digits += ch;
                }
                else if (char.IsLetter(ch))
                {
                    letters += ch;
                }
                else
                {
                    other += ch;
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(other);
        }
    }
}
