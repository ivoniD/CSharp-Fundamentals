using System;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            // 145 = 1! + 4! + 5!;
            long factorialSum = 0;

            for (int i = 0; i <= number.Length -1; i++)
            {
                char currentCharacter = number[i]; // 49 - 52 - 53
                int curDigit = (int)currentCharacter - 48; // 1 - 4 - 5
                long curDigitFactorial = 1;
                for (int j = curDigit; j > 1; i--)
                {
                    curDigitFactorial *= j;
                }
                factorialSum += curDigitFactorial;
                
            }
            Console.WriteLine(factorialSum);
        }
    }
}
