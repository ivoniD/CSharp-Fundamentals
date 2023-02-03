using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 2 3 3  - At a[2] -> left sum = 3, right sum = 3   - a[0] + a[1] = a[3] 

            int[] numArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int currentSimbol = 0;
            bool isTrue = false;
            for (int i = 0; i < numArray.Length; i++) //1 2 3 3
            {
                int leftSum = 0;
                int rightSum = 0;
                if (i == 0 || i == numArray.Length - 1)
                {
                    leftSum = 0;
                    rightSum = 0;
                }

                for (int j = i + 1; j < numArray.Length; j++) // 2 3 3 
                {
                    rightSum = rightSum + numArray[j];


                }
                if (i > 0)
                {
                    for (int k = i - 1; k >= 0; k--)
                    {
                        leftSum = leftSum + numArray[k];
                    }
                }
                if (leftSum == rightSum)
                {
                    isTrue = true;
                    currentSimbol = i;
                    break;

                }
            }
            if (isTrue)
            {
                Console.WriteLine(currentSimbol);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
