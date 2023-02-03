using System;

namespace _3._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int numOfPeople = int.Parse(Console.ReadLine());
             int capacityOfPeople = int.Parse(Console.ReadLine());

            int allcources = numOfPeople / capacityOfPeople;
            if (numOfPeople % capacityOfPeople != 0)
            {
                int fullCources = numOfPeople / capacityOfPeople;
                allcources = fullCources + 1;
            }
            Console.WriteLine(allcources);
        }
    }
}
