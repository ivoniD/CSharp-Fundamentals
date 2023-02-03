using System;

namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	On the first line, you will receive n – the number of lines, which will follow
            //•	On the next n lines – you will receive letters from the Latin alphabet

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                char digit = char.Parse(Console.ReadLine());
                //int curChCode = (int)digit
                //sum += curChCode
                sum += digit; 
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
