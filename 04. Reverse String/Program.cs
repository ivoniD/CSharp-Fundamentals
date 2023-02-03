using System;

namespace _04._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();
            string reversedInput = string.Empty;
            for (int i = input.Length - 1; i >=0; i--)
            {
                reversedInput += input[i];
            }
            Console.WriteLine(reversedInput);
        }
    }
}
