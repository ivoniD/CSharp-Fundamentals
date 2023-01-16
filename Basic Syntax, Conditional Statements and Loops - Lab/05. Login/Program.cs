using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string pass = String.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                pass += username[i];
            }

            for (int counter = 1; counter <= 4; counter++)
            {
                string tryTolog = Console.ReadLine();
                if (tryTolog == pass)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    continue;
                }

            }
        }
    }
}
