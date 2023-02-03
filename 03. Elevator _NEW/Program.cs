using System;

namespace _03._Elevator__NEW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            int capacityOfPeople = int.Parse(Console.ReadLine());

            double allCources = Math.Ceiling((double) numOfPeople / capacityOfPeople);
            Console.WriteLine(allCources);
        }
    }
}
