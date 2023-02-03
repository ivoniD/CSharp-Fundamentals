using System;
using System.Linq;

namespace P_08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = Console.ReadLine()
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            int magicNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < numArray.Length; i++)
            {
                for (int k = i + 1; k < numArray.Length; k++)
                {
                    if (numArray[i] + numArray[k] == magicNum)
                    {
                        Console.WriteLine($"{numArray[i]} {numArray[k]}");
                    }
                }
            }
        }
    }
}
