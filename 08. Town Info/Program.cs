using System;

namespace _08._Town_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"Town {town name} has population of {population} and area {area} square km".

            string townName = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            uint area = uint.Parse(Console.ReadLine());

            Console.WriteLine($"Town {townName} has population of {population} and area {area} square km.");

        }
    }
}
