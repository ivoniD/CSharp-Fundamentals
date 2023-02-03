using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= num; i++)
            {    
               int curNum = i;
               int sum = 0;

                while (curNum != 0)
                {
                    sum += curNum % 10;
                    curNum = curNum / 10;
                }

                bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {isSpecial}");
            }

        }
    }
}
