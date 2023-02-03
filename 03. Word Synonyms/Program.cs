using System;
using System.Collections.Generic;

namespace P03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonymDic = new Dictionary<string, List<string>>();

            for (int i = 1; i <= n; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();

                if (synonymDic.ContainsKey(word))
                {
                    synonymDic[word].Add(synonim);
                }
                else
                {
                    List<string> newSymList = new List<string>();
                    newSymList.Add(synonim);
                    synonymDic.Add(word, newSymList);
                }
            }
            foreach (var item in synonymDic)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }


        }
    }
}
