using System;

namespace _6._Reversed_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that takes 3 lines of characters and prints them in reversed order with a space between them.

            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());

            Console.WriteLine($"{c} {b} {a}");
        }
    }
}
