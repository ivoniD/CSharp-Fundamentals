using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] inputAsChars = input.ToCharArray();
            int currentPower = 0;
            string result = string.Empty;

            bool isPunch = false;

            for (int i = 0; i < inputAsChars.Length; i++)
            {
                if (inputAsChars[i] == '>')
                {
                    isPunch = true;
                    continue;
                }

                if (isPunch)
                {
                    currentPower += inputAsChars[i] - 48;
                    isPunch = false;
                }

                if (currentPower > 0)
                {
                    inputAsChars[i] = '0';
                    currentPower--;
                }

            }
            foreach (var ch in inputAsChars)
            {
                if (ch != '0')
                {
                    result += ch;
                }
            }
            Console.WriteLine(result);
        }
    }
}