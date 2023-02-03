using System;

namespace P06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //aString
            string input = Console.ReadLine();
            string midNums = MiddleNums(input);
            Console.WriteLine(midNums);

        }
        static string MiddleNums(string input)
        {
            string midNums = string.Empty;
            if (input.Length % 2 != 0)
            {
                int index = input.Length / 2;
                midNums = (input[index]).ToString();
                return midNums;
            }
            else // 4 // 3245
            {
                int index = input.Length / 2;
                midNums = input[index - 1].ToString() + input[index].ToString();
                return midNums;
            }

        }
    }
}
