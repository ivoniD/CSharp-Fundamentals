using System;

namespace P06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine(area(width, height));
        }
        static double area(int widht, int height)
        {
            return widht * height;
        }
    }
}
