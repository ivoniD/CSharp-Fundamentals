using System;

namespace _5._Decrypting_Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine()); // 3
            int n = int.Parse(Console.ReadLine());  // 7

            int counter = 0;
            string message = string.Empty;
            while (true)
            {
                counter++;
                var input = Console.ReadLine(); // P // l 
                int curtLetter = char.Parse(input) + key;
                char rightLetter = (char)curtLetter;
               message += rightLetter;
                if (counter == n)
                {
                    Console.Write(message);
                    return;
                }
            }

           


        }
    }
}
