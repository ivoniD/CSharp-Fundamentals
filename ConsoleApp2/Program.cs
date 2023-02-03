using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numSequence = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int[] cmdArgs = (int[])Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int bombNum = cmdArgs[0];
            int bombPower = cmdArgs[1];



            while (numSequence.Contains(bombNum))
            {
                int indexOfBomb = numSequence.IndexOf(bombNum);
                int startRange = indexOfBomb - bombPower;
                int removeElements = bombPower * 2 + 1;
                if (startRange < 0)
                {
                    int diff = Math.Abs(startRange);
                    startRange = 0;
                    removeElements = removeElements - diff;
                }
                if ((startRange + removeElements) - startRange > numSequence.Count - 1)
                {
                    int diff = (startRange + removeElements) - removeElements; //2
                    removeElements -= diff;
                }

                numSequence.RemoveRange(startRange, removeElements);
            }

            Console.WriteLine(numSequence.Sum());

        }
    }
}
