using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double maxNum = double.MinValue;
            string maxModel = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                //π * r^2 * h. 
                double volume = Math.PI * (radius*radius) * height;

                if (volume > maxNum)
                {
                    maxNum = volume;
                    maxModel = model;
                }
            }
            Console.WriteLine(maxModel);

        }
    }
}
