using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 1 1 2 3 1 3 3

            int[] numArray = Console.ReadLine()
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();

            int maxSeq = int.MinValue;
            int counter = 1;
            int maxNum = 0;

            for (int i = 0; i < numArray.Length - 1; i++)
            {
                counter = 1;
                for (int k = i + 1; k < numArray.Length; k++)
                {
                    if (numArray[i] == numArray[k]) // 1 == 1 / 1 == 1
                    {
                        counter++;//2 // 3
                        if (counter > maxSeq)
                        {
                            maxSeq = counter;
                            maxNum = numArray[i];
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            int[] equalsArray = new int[maxSeq];
            for (int i = 0; i < equalsArray.Length; i++)
            {
                equalsArray[i] = maxNum;
            }
            Console.WriteLine(string.Join(' ', equalsArray));
        }
    }
}
