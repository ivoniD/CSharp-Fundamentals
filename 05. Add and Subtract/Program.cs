using System;

namespace P05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(result(num1, num2, num3));
        }
        static int result(int num1, int num2, int num3)
        {
            int sum = Sum(num1, num2);
            int result = sum - num3;
            return result;
        }
        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

    }
}
