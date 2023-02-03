using System;

namespace P08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());
            double result = Reslt(num, pow);
            Console.WriteLine(result);
        }
        static double Reslt(double num, int power)
        {
            double result = 1.0;
            for (int i = 1; i <= power; i++)
            {
                result *= num;
            }
            return result;
        }
    }
}
