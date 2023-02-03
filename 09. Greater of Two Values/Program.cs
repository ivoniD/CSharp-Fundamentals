using System;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //You are given an input of two values of the same type. 
            //The values can be of type int, char, or string.Create methods called GetMax(), 
            //which can compare int, char, or string and returns the biggest of the two values.

            string type = Console.ReadLine();
            if (type == "int")
            {
                int firstInput = int.Parse(Console.ReadLine());
                int secondInput = int.Parse(Console.ReadLine());
                int result = GetMax(firstInput, secondInput);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char firstInput = char.Parse(Console.ReadLine());
                char secondInput = char.Parse(Console.ReadLine());
                char result = GetMax(firstInput, secondInput);
                Console.WriteLine(result);
            }
            else if (type == "string")
            {
                string firstInput = Console.ReadLine();
                string secondInput = Console.ReadLine();
                string result = GetMax(firstInput, secondInput);
                Console.WriteLine(result);
            }

        }
        static int GetMax(int firstInput, int secondInput)
        {
            return firstInput >= secondInput ? firstInput : secondInput;
        }
        static char GetMax(char firstInput, char secondInput)
        {
            return firstInput >= secondInput ? firstInput : secondInput;
        }
        static string GetMax(string firstInput, string secondInput)
        {
            return firstInput.CompareTo(secondInput) > 0 ? firstInput : secondInput;
        }
    }
}
