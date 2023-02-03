using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program to enter n numbers and calculate and print their exact sum (without rounding).

            int n = int.Parse(Console.ReadLine());
            decimal sum = 0M;
            for (int i = 1; i <= n; i++)
            {
                double curNum = double.Parse(Console.ReadLine());
                sum += (decimal)curNum;
            }
            Console.WriteLine(sum);
        }
    }
}
