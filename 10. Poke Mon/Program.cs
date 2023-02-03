using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long pokePower = long.Parse(Console.ReadLine()); // N
            int distance = int.Parse(Console.ReadLine()); // M - distance between the poke targets
            int exhaustionFactor = int.Parse(Console.ReadLine()); // Y 
            long currPokePower = pokePower;
            int counter = 0;

            while (currPokePower >= distance)
            {
                currPokePower = currPokePower - distance;
                counter++;
                if (pokePower % 2 == 0)
                {
                    if (currPokePower == pokePower / 2 && exhaustionFactor != 0)
                    {
                        currPokePower = currPokePower / exhaustionFactor;
                    }
                } 
            }
                Console.WriteLine(currPokePower);
                Console.WriteLine(counter);
           
        }
    }
}
