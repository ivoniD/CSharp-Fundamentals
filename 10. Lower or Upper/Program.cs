using System;

namespace _10._Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that prints whether a given character is upper-case or lower case.
            char letter = char.Parse(Console.ReadLine());

            bool result;
            result = char.IsUpper(letter);

            if (result)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
            
        }
    }
}
