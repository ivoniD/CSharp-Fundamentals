using System;
using System.Linq;

namespace P_Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] realNums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < realNums.Length; i++)
            {
                Console.WriteLine($"{realNums[i]} => {Math.Round(realNums[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}