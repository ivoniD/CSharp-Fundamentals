using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] twoWords = Console.ReadLine().Split(' '); // Peter George

            string firstWord = twoWords[0];
            string secondWord = twoWords[1];

            int finalSum = GetStringSum(firstWord, secondWord);
            Console.WriteLine(finalSum);

        }

        private static int GetStringSum(string stringOne, string stringTwo)
        {

            int sum = 0;
            int minLength = Math.Min(stringOne.Length, stringTwo.Length);

            for (int i = 0; i < minLength; i++)
            {
                sum += (stringOne[i] * stringTwo[i]);
            }
            string longestLength = stringOne;
            if (stringTwo.Length > longestLength.Length)
            {
                longestLength = stringTwo;
            }
            for (int i = minLength; i < longestLength.Length; i++)
            {
                sum += longestLength[i];
            }


            return sum;

        }
    }
}
