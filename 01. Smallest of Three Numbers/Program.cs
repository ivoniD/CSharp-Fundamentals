using System;

namespace P01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a method that prints out the smallest of three integer numbers.
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int[] numArray = new int[] { num1, num2, num3 };
            int minNum = SmallestNum(numArray);
            Console.WriteLine(minNum);
        }
        static int SmallestNum(int[] numArray)
        {
            int min = numArray[0];
            foreach (int n in numArray)
            {
                if (n < min)
                {
                    min = n;
                }
            }
            return min;
        }
    }
}
