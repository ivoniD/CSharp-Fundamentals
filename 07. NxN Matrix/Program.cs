using System;

namespace P07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                MatrixRow(n);
                Console.WriteLine();
            }
        }
        static void MatrixRow(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{n} ");
            }
        }
    }
}
