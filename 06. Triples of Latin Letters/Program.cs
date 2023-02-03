using System;

namespace _06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that receives an integer n and print all triples of the first n small Latin letters, ordered alphabetically:
            int n = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < 'a' + n; i++)
            {
                for (char j = 'a'; j < 'a' + n; j++)
                {
                    for (char k = 'a'; k <'a' + n; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}
