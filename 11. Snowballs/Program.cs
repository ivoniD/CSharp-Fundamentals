using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //•	The snowballSnow is an integer in the range[0, 1000].
            //•	The snowballTime is an integer in the range[1, 500].
            //•	The snowballQuality is an integer in the range[0, 100].

            int n  = int.Parse(Console.ReadLine()); // number of snowballs
            BigInteger BestsnowballValue = BigInteger.Zero;
            int bestSnowballSnow = 0;
            int bestSnowballTime = 0;
            int bestSnowballQuality = 0;

            for (int i = 1; i <= n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                int snowballD = snowballSnow / snowballTime;
                BigInteger snowballValue = BigInteger.Pow(snowballD, snowballQuality);

                if (snowballValue > BestsnowballValue)
                {
                    BestsnowballValue = snowballValue;
                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                    bestSnowballQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {BestsnowballValue} ({bestSnowballQuality})");
        }
    }
}
