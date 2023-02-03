using System;

namespace strong_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 145 = 1! + 4! + 5!;
            string num = Console.ReadLine();

            int factorialSum = 0;

            for (int i = 0; i <= num.Length - 1; i++)
            {
                char currentCharacter = num[i]; // 49 - 52 - 53
                int currDigit = (int)currentCharacter - 48; 
                int currDigitFactorial = 1;
                for (int j = currDigit; j > 1; i--)
                {
                    currDigitFactorial *= j;
                }
                factorialSum += currDigitFactorial;

            }

            if (factorialSum == int.Parse(num))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
                
           
            
            
        }
    }
}
