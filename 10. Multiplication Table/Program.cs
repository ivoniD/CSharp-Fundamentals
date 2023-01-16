using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            //{theInteger} X {times} = {product}
            int n = int.Parse(Console.ReadLine());
            int prod = 0;
            for (int i = 1; i <= 10; i++)
            {
                prod = n * i;
                Console.WriteLine($"{n} X {i} = {prod}");
            }
        }
    }
}
