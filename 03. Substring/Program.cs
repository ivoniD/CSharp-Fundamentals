using System;

namespace substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine(); //her
            string secondString = Console.ReadLine();//herbebeher

            while (secondString.Contains(firstString))
            {
                int wordIndex = secondString.IndexOf(firstString);
                secondString = secondString.Remove(wordIndex, firstString.Length);

            }
            Console.WriteLine(secondString);

        }
    }
}
