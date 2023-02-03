using System;

namespace _4.__Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programming is cool!

            string message = Console.ReadLine();
            string cipheredMessage = string.Empty;

            for (int i = 0; i < message.Length; i++)
            {
                char letter = (char)(message[i] + 3);
                cipheredMessage += letter;

            }

            Console.WriteLine(cipheredMessage);

        }
    }
}
