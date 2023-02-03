using System;
using System.Linq;

namespace P10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int magicNum = 8;
            string n = Console.ReadLine();//50
            int num = Convert.ToInt32(n);
            int number = 0;
            for (int i = 1; i <= num; i++)
            {
                number = i;
                if (DevidedBy(magicNum, number) == true && OddDigitsHold(n, number) == true)
                {
                    Console.WriteLine(number);
                }
            }
        }
        static bool DevidedBy(int magicNum, int number)
        {
            bool isDevided = false;
            int digitSum = 0;

            while (number != 0)
            {
                int currentNum = number;
                digitSum += currentNum % 10;
                number = number / 10;
            }

            if (digitSum % magicNum == 0)
            {
                isDevided = true;
            }

            return isDevided;
        }
        static bool OddDigitsHold(string n, int number)
        {
            bool holdDigit = false;

            while (number != 0)
            {
                int currentNum = number % 10;
                if (currentNum % 2 != 0)
                {
                    holdDigit = true;
                }
                number = number / 10;
            }

            return holdDigit;
        }
    }
}
