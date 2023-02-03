using System;

namespace repeat_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Each String is Repeated N Times, Where N is the length of the String. Print the Concatenated String.

            string[] words = Console.ReadLine().Split(' ');

            string result = string.Empty;

            foreach (string currWord in words)
            {
                for (int i = 0; i < currWord.Length; i++)
                {
                    result += currWord;
                }
            }

            Console.WriteLine(result);


        }
    }
}
