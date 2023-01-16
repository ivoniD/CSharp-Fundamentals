using System;

namespace stron_fin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int factorial = 0;

            for (int i = 0; i <= number.Length - 1; i++)
            {
                char currCharacter = number[i];
                int currDigit = (int)currCharacter - 48;

                int currDigitFactorial = 1;
                for (int j = currDigit; j >= 1; j--)
                {
                    currDigitFactorial = currDigitFactorial * j;
                }
                factorial += currDigitFactorial;
            }
            if (factorial == int.Parse(number))
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
