using System;

namespace P09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            double result = Calculation(num1, num2, @operator);
            Console.WriteLine(result);
        }
        static double Calculation(int num1, int num2, string @operator)
        {
            double result = 0;
            switch (@operator)
            {
                case "/":
                    result = num1 / num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
            }
            return result;
        }

    }
}
