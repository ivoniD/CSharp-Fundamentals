using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //((daysInMonth * capsulesCount) * pricePerCapsule)

            int numOfOrders = int.Parse(Console.ReadLine());

            int daysInMonth = 0;
            int capsulesCount = 0;
            double pricePerCapsule = 0;
            double price = 0;
            double totalPrice = 0;
            for (int i = 1; i <= numOfOrders; i++)
            {
                pricePerCapsule = double.Parse(Console.ReadLine());
                daysInMonth = int.Parse(Console.ReadLine());
                capsulesCount = int.Parse(Console.ReadLine());

                price = ((daysInMonth * capsulesCount) * pricePerCapsule);
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
                totalPrice += price;
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
