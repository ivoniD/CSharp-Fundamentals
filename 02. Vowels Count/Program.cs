using System;
using System.Linq;

namespace P02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a method that receives a single string and prints out the number of vowels contained in it. // SoftUni

            string word = Console.ReadLine();
            int vowels = VowelsCount(word);
            Console.WriteLine(vowels);
        }
        static int VowelsCount(string word)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int vowelsCount = 0;
            //foreach (char ch in word)
            //{
            //    if (vowels.Contains(ch))
            //    {
            //        vowelsCount++;
            //    }
            //};

            for (int i = 0; i < word.Length; i++)
            {
                if (vowels.Contains(word[i]))
                {
                    vowelsCount++;
                }
            }
            return vowelsCount;
        }
    }
}
