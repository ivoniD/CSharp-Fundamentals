using System;
using System.Text;

namespace _6.__Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); // aaaaabbbbbcdddeeeedssaa
            StringBuilder sb = new StringBuilder();
            sb.Append(input[0]);
            for (int i = 0; i < input.Length - 1; i++)
            {
                char letter = input[i];
                if (input[i] != input[i + 1])
                {
                    sb.Append(input[i + 1]);
                }
            }

            Console.WriteLine(sb);
        }
    }
}
