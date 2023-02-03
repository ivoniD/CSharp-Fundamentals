using System;

namespace P04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //1 2
            //1 2 3
            //1 2
            //1

            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i < num; i++)//1
            {
                PrintTriangle(1, i);
            }
            for (int i = num; i >= 1; i--)
            {
                PrintTriangle(1, i);
            }
        }
        static void PrintTriangle(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
