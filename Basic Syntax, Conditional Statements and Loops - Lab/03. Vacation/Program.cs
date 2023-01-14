using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numpeople = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;
            if (type == "Students")
            //Students   8.45   9.80   10.46
            //Students >= 30 -> price - 15%
            {
                if (day == "Friday")
                {
                    price = numpeople * 8.45;
                }
                else if (day == "Saturday")
                {
                    price = numpeople * 9.80;
                }
                else if (day == "Sunday")
                {
                    price = numpeople * 10.46;
                }
                if (numpeople >= 30)
                {
                    price = price - (price * 0.15);
                }
            }
            else if (type == "Business")
            //Business  10.90   15.60   16
            //Business >=  100 -> 10 of the people stay for free.
            {
                if (day == "Friday")
                {
                    price = numpeople * 10.90;
                    if (numpeople >= 100)
                    {
                        price = price - (10 * 10.90);
                    }
                }
                else if (day == "Saturday")
                {
                    price = numpeople * 15.60;
                    if (numpeople >= 100)
                    {
                        price = price - (10 * 15.60);
                    }
                }
                else if (day == "Sunday")
                {
                    price = numpeople * 16;
                    if (numpeople >= 100)
                    {
                        price = price - (10 * 16);
                    }
                }

            }
            else if (type == "Regular")
            //Regular   15    20    22.50
            //Regular >= 10 && <=20 -> price - 5%
            {
                if (day == "Friday")
                {
                    price = numpeople * 15;
                }
                else if (day == "Saturday")
                {
                    price = numpeople * 20;
                }
                else if (day == "Sunday")
                {
                    price = numpeople * 22.50;
                }
                if (numpeople >= 10 && numpeople <= 20)
                {
                    price = price - (price * 0.05);
                }
            }
            Console.WriteLine($"Total price: {price:f2}");


        }
    }
}
