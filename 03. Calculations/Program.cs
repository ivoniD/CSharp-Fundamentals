using System;

namespace P03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mathOperation = Console.ReadLine();
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            Action(mathOperation, num1, num2);
        }
        static void Action(string mathOperation, double num1, double num2)
        {
            double sum = 0;

            if (mathOperation == "add")
            {
                sum = num1 + num2;
            }

            else if (mathOperation == "multiply")
            {
                sum = num1 * num2;
            }

            else if (mathOperation == "subtract")
            {
                sum = num1 - num2;
            }

            else if (mathOperation == "divide")
            {
                sum = num1 / num2;
            }
            Console.WriteLine(sum);
        }

    }
}
