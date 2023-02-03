using System;
using System.Linq;

namespace P_04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program to find all the top integers in an array.
            //A top integer is an integer that is greater than all the elements to its right.
            //1 4 3 2	4 3 2
            //27 19 42 2 13 45 48	48
            // 0 1 2 3
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray(); // 1 4 3 2

            for (int i = 0; i < array.Length; i++) // 2
            {
                bool isTop = true;
                for (int j = i + 1; j < array.Length; j++)
                {

                    if (array[i] <= array[j]) // 4 > 3 / 4 > 2
                    {
                        isTop = false;
                        break;
                    }

                }
                if (isTop)
                {
                    Console.Write($"{array[i]} ");
                }

            }
        }
    }
}
