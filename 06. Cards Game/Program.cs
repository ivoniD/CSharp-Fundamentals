using System;
using System.Collections.Generic;
using System.Linq;

namespace P6._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> sedondPlayer = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (firstPlayer.Count != 0 && sedondPlayer.Count != 0)
            {
                if (firstPlayer[0] == sedondPlayer[0])
                {
                    firstPlayer.Remove(firstPlayer[0]);
                    sedondPlayer.Remove(sedondPlayer[0]);
                }
                else if (firstPlayer[0] > sedondPlayer[0])
                {
                    firstPlayer.Add(sedondPlayer[0]);
                    firstPlayer.Add(firstPlayer[0]);

                    firstPlayer.Remove(firstPlayer[0]);
                    sedondPlayer.Remove(sedondPlayer[0]);
                }
                else if (sedondPlayer[0] > firstPlayer[0])
                {
                    sedondPlayer.Add(firstPlayer[0]);
                    sedondPlayer.Add(sedondPlayer[0]);

                    sedondPlayer.Remove(sedondPlayer[0]);
                    firstPlayer.Remove(firstPlayer[0]);
                }
            }
            if (firstPlayer.Count == 0)
            {
                int sum = sedondPlayer.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
            else
            {
                int sum = firstPlayer.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
        }
    }
}
