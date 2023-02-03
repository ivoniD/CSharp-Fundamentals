using System;

namespace DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //.
            string command = Console.ReadLine();

            while (command != "end")
            {
                string reversed = string.Empty;

                for (int i = command.Length - 1; i >= 0; i--)
                {
                    reversed += command[i];
                }

                Console.WriteLine($"{command} = {reversed}");

                command = Console.ReadLine();
            }

        }
    }
}
