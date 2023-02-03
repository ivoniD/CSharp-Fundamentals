using System;

namespace text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedList = Console.ReadLine().Split(", ");

            string text = Console.ReadLine();

            foreach (string banWord in bannedList)
            {
                string asterix = string.Empty;
                for (int i = 0; i < banWord.Length; i++)
                {
                    asterix += '*';
                }
                text = text.Replace(banWord, asterix);
            }

            Console.WriteLine(text);
        }
    }
}
