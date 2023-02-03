using System;
using System.Text;

namespace _2.fromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            /*You will receive number which represent how many lines we will get as an input. On the next N lines, you will receive a string with 2 numbers separated by single space. You need to compare them. If the left number is greater than the right number, you need to print the sum of all digits in the left number, otherwise print the sum of all digits in the right number.*/

            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                StringBuilder left = new StringBuilder();
                StringBuilder right = new StringBuilder();
                bool space = false;
                for (int j = 0; j < input.Length; j++)
                {
                    if (char.Parse(Convert.ToString(input[j])) == ' ')
                    {
                        space = true;
                        continue;
                    }
                    if (!space)
                    {
                        left.Append(input[j]);
                    }
                    else
                    {
                        right.Append(input[j]);
                    }
                }
                float sum = 0;
                if (double.Parse(Convert.ToString(left)) > double.Parse(Convert.ToString(right)))
                {

                    for (int k = 0; k < Convert.ToString(left).Length; k++)
                    {
                        bool symbol = int.TryParse(Convert.ToString(left[k]), out int digit);
                        sum += digit;
                    }
                }
                else
                {
                    for (int k = 0; k < Convert.ToString(right).Length; k++)
                    {
                        bool symbol = int.TryParse(Convert.ToString(right[k]), out int digit);
                        sum += digit;
                    }
                }
                Console.WriteLine(sum);
            }
        }
    }
}