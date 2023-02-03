using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int curNum = n;

            while (true)
            {
                int currentDig = curNum % 10; 
                sum = sum + currentDig; 
                curNum = curNum / 10; 

                if (curNum == 0)
                {
                    break;
                }
            }
            Console.WriteLine(sum);




        }
    }
}
