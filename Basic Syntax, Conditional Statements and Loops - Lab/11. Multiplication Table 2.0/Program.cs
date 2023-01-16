using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            //{theInteger} X {times} = {product}
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int prod = 0;

            for (int i = k; i <= 10; i++)
            {
                prod = n * i;
                Console.WriteLine($"{n} X {i} = {prod}");
            }
            if (k > 10)
            {
                Console.WriteLine($"{n} X {k} = {n * k}");
            }
        }
    }
}
