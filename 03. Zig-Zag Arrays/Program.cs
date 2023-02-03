using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArray = new int[n];
            int[] secondArray = new int[n];
            int counter = 1;

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (counter % 2 != 0)
                {
                    int[] currentArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    for (int j = 0; j < currentArr.Length - 1; j++)
                    {
                        firstArray[i] = currentArr[j];
                        secondArray[i] = currentArr[j + 1];
                    }
                }
                else
                {
                    int[] currentArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    for (int j = 0; j < currentArr.Length - 1; j++)
                    {
                        firstArray[i] = currentArr[j + 1];
                        secondArray[i] = currentArr[j];
                    }
                }
                counter++;

            }
            Console.WriteLine(String.Join(' ', firstArray));
            Console.WriteLine(String.Join(' ', secondArray));

        }
    }
}
