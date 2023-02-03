using System;

namespace P08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            double result = DivideFactorials(num1, num2);
            Console.WriteLine($"{result:f2}");
        }
        static double FactorialNum1(double num1)
        {
            double factorial = 1;
            for (double i = num1; i >= 1; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
        static double FactorialNum2(double num2)
        {
            double factorial = 1;
            for (double i = num2; i >= 1; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
        static double DivideFactorials(double num1, double num2)
        {
            double result = FactorialNum1(num1) / FactorialNum2(num2);
            return (result);
        }
    }
}
