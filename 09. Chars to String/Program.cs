using System;

namespace _09._Chars_to_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads 3 lines of input.On each line, you get a single character.
            //Combine all the characters into one string and print it on the console.

            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());

            Console.WriteLine($"{a}{b}{c}");
        }
    }
}
