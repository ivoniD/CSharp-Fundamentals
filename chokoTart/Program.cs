using System;

namespace chokoTart
{
    internal class Program
    {
        static void Main(string[] args)
        {

           int grams = int.Parse(Console.ReadLine());
           int allgrams = 0;
            while (true)
            {
                allgrams += grams;
                if (allgrams >= 250)
                {
                    if (allgrams > 250)
                    {
                        int diff = allgrams - 250;
                        Console.WriteLine($"Stop it, {diff} more!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"150! Stop!");
                        break;
                    }
                    
                }
                grams = int.Parse(Console.ReadLine());
            }
            
        }
    }
}
