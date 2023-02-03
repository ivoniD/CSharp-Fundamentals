using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            int totalamount = 0;
            int yeild = n;
           
            while (true)
            {
                if (n < 100)
                {
                    Console.WriteLine(counter);
                    Console.WriteLine(totalamount);
                        return;
                }
                if (yeild >= 100)
                {
                    int amount = yeild - 26;
                    totalamount += amount;
                    yeild = yeild - 10;
                    counter++;
                }
                if (yeild < 100)
                {
                    break;
                }
            }

            if (yeild < 100)
            {
                totalamount = totalamount - 26;
                Console.WriteLine(counter);
                Console.WriteLine(totalamount);
                
            }
        }
    }
}
