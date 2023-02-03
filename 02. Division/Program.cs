using System;

namespace _02._Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;

            //if the given integer is divisible by 2, or 3,  or 6,  or 7, or 10 without a reminder. You should always take the bigger division:
            int percent;
            
                if (num % 2 == 0)
                {
                    percent = 2;
                    // Console.WriteLine(2);
                    if (percent > maxNum)
                    {
                    maxNum = percent;
                    }
                }
                if (num % 3 == 0)
                {
                    percent = 3;
                    if (percent > maxNum)
                    {
                    maxNum = percent;
                }
                    // Console.WriteLine(3);
                }
                if (num % 6 == 0)
                {
                    percent = 6;
                    if (percent > maxNum)
                    {
                    maxNum = percent;
                }
                    //Console.WriteLine(6);
                }
                if (num % 7 == 0)
                {
                    percent = 7;
                    if (percent > maxNum)
                    {
                    maxNum = percent;
                }
                    //Console.WriteLine(7);
                }
                if (num % 10 == 0)
                {
                    percent = 10;
                    if (percent > maxNum)
                    {
                        maxNum = percent;
                    }
                    //Console.WriteLine(10);
                }
            if (num % 2 != 0 && num % 3 != 0 && num % 6 != 0 && num % 7 != 0 && num % 10 != 0)
            {
                Console.WriteLine("Not divisible");
                return;
            }
                Console.WriteLine($"The number is divisible by {maxNum}");
             
            

            
        }
    }
}
