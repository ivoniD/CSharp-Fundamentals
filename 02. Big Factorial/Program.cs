using System;
using System.Numerics;

namespace P02._Big_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factorialSum = 1;

            for (int i = 1; i <= n; i++)
            {
                factorialSum = i * factorialSum;
            }
            Console.WriteLine(factorialSum);
        }
    }
}
