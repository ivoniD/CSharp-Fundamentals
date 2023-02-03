using System;
using System.Linq;

namespace P_01._Encrypt__Sort_and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	The code of each vowel multiplied by the string length
            //•	The code of each consonant divided by the string length

            int n = int.Parse(Console.ReadLine());

            string[] namesArray = new string[n];
            int[] resultArray = new int[n];
            for (int i = 0; i < namesArray.Length; i++)
            {
                int sumVowel = 0;
                int sumConstant = 0;
                int allSum = 0;
                namesArray[i] = Console.ReadLine();
                string currName = namesArray[i];// Peter - Maria - Katya - Todor
                for (int k = 0; k < currName.Length; k++)
                {
                    char currLetter = currName[k];
                    if (currName[k] != 'a' && currName[k] != 'e' && currName[k] != 'i' && currName[k] != 'o' && currName[k] != 'u'
                        && currName[k] != 'A' && currName[k] != 'E' && currName[k] != 'I' && currName[k] != 'O' && currName[k] != 'U')
                    {
                        sumConstant += currLetter / currName.Length;
                    }
                    else
                    {
                        sumVowel += currLetter * currName.Length;
                    }

                }
                allSum = sumConstant + sumVowel;
                resultArray[i] = allSum;

            }

            for (int p = 0; p < resultArray.Length; p++)
            {
                Array.Sort(resultArray);
                Console.WriteLine(resultArray[p]);
            }

        }
    }
}

