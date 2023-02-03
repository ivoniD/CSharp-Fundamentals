using System;

namespace P1._Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	If the data type is int, multiply the number by 2.
            //•	If the data type is real, multiply the number by 1.5 and format it to the second decimal point.
            //•	If the data type is a string, surround the input with "$".

            string input = Console.ReadLine();

            if (input == "int")
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(Print(num));
            }
            else if (input == "real")
            {
                double num = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Print(num):f2}");

            }
            else if (input == "string")
            {
                string str = Console.ReadLine();
                Console.WriteLine(Print(str));
            }
        }
        static int Print(int num)
        {
            return num * 2;
        }
        static double Print(double num)
        {
            return num * 1.5;
        }
        static string Print(string str)
        {
            return "$" + str + "$";
        }
    }
}
