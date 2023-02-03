using System;

namespace P09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                if (PalindromeOrNot(command))
                {
                    Console.WriteLine(PalindromeOrNot(command));
                }
                else
                {
                    Console.WriteLine(PalindromeOrNot(command));
                }
            }
        }
        static bool PalindromeOrNot(string command)
        {
            bool result = false;
            string currRev = string.Empty;

            for (int i = command.Length - 1; i >= 0; i--)
            {
                currRev += command[i];
                if (currRev == command)
                {
                    result = true;
                }
            }
            return result;
        }

    }
}
