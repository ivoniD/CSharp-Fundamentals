using System;

namespace _1._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int firstNum = 0;
            int secondNum = 0;
            int thirdNum = 0;

            if (a > b && a > c)
            {
                firstNum = a;
            }
            else if (b > a && b > c)
            {
                firstNum = b;
            }
            else if (c > a && c > b)
            {
                firstNum = c;
            }
            if (a < b && a < c)
            {
                thirdNum = a;
            }
            else if (b < a && b < c)
            {
                thirdNum = b;
            }
            else if (c < a && c < b)
            {
                thirdNum = c;
            }
            if (a != firstNum && a != thirdNum)
            {
                secondNum = a;
            }
            else if (b != firstNum && b != thirdNum)
            {
                secondNum = b;
            }
            else if (c != firstNum && c != thirdNum)
            {
                secondNum = c;
            }

            Console.WriteLine(firstNum);
            Console.WriteLine(secondNum);
            Console.WriteLine(thirdNum);

        }
    }
}
