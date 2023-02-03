using System;
using System.Linq;

namespace P10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Create a method called GetMultipleOfEvenAndOdds()

            int number = Math.Abs(int.Parse(Console.ReadLine())); // 12345
            int result = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(GetMultipleOfEvenAndOdds(number));

        }
        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            int currentNum = number;

            while (currentNum != 0)
            {
                if ((currentNum % 10) % 2 == 0)
                {
                    sum += currentNum % 10;
                }
                currentNum = currentNum / 10;
            }

            return sum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            int currentNum = number;

            while (currentNum != 0)
            {
                if ((currentNum % 10) % 2 != 0)
                {
                    sum += currentNum % 10;
                }
                currentNum = currentNum / 10;
            }

            return sum;
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
        }
    }
}
