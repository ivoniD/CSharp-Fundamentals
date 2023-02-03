using System;
using System.Linq;

namespace P_Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that calculates the difference
            //between the sum of the even and the sum of the odd numbers in an array.
            // 1 2 3 4 5 6 	3

            int[] numArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumEven = 0;
            int sumOdd = 0;
            for (int i = 0; i < numArr.Length; i++)
            {
                if (numArr[i] % 2 == 0)
                {
                    sumEven += numArr[i];
                }
                else
                {
                    sumOdd += numArr[i];
                }
            }
            Console.WriteLine(sumEven - sumOdd);
        }
    }
}
