using System;
using System.Numerics;

namespace _05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //the char index you should start with, and on the second line -the index of the last character

            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                Console.Write($"{(char)i} ");
            }
            BigInteger bigint = 1;

        }
    }
}
