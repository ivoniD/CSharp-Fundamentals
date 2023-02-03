using System;
using System.Linq;

namespace P_04._Array_Rotation_N
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //51 47 32 61 21
            //2

            int[] numArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());
            int[] rotatedArray = numArray;

            for (int rotations = 0; rotations < n; rotations++)
            {
                int lastNum = rotatedArray[0];
                for (int i = 0; i < numArray.Length - 1; i++) // 4
                {

                    rotatedArray[i] = numArray[i + 1];
                }
                rotatedArray[rotatedArray.Length - 1] = lastNum;
            }
            Console.WriteLine(string.Join(' ', rotatedArray));
        }

    }
}
