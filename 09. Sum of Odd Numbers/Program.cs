using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that prints on a new line the next n odd numbers (starting from 1).
            //On the last row prints the sum of all n odd numbers.

            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++) // 1 2 3 4 5 
            {
                int curentnum = 1 + (i * 2);

                Console.WriteLine(curentnum);
                sum += curentnum;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
