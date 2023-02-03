using System;

namespace P_Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] items = new int[n];

            for (int i = 0; i < items.Length; i++)

            {
                items[i] = int.Parse(Console.ReadLine());

            }
            Array.Reverse(items);
            Console.WriteLine(string.Join(' ', items));
        }
    }
}
