using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double JohnsMoney = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            double lightsabers = double.Parse(Console.ReadLine());
            double robes = double.Parse(Console.ReadLine());
            double belts = double.Parse(Console.ReadLine());

            double studentsWith10Pr = (Math.Ceiling(studentsCount + (studentsCount * 0.1)));
            double lightsabersPrice = lightsabers * studentsWith10Pr;  // 2
            double robesPrice = robes * studentsCount; // 4
            double beltsPrice = belts * studentsCount; // 6

            if (studentsCount > 6)
            {
                double discount = (studentsCount / 6);
                beltsPrice = beltsPrice - (discount * belts);
            }

            double neededMoney = lightsabersPrice + robesPrice + beltsPrice;

            if (JohnsMoney >= neededMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {neededMoney:f2}lv.");
            }
            if (JohnsMoney < neededMoney)
            {
                Console.WriteLine($"John will need {(neededMoney - JohnsMoney):f2}lv more.");
            }



        }
    }
}
