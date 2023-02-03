using System;
using System.Linq;

namespace P_Sum_Even_Numbers
{
    internal class Program
    {
        public static object Select { get; private set; }

        static void Main(string[] args)
        {
            //Read an array from the console and sum only its even values. 
            // 1 2 3 4 5 6	   12

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    sum += nums[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
