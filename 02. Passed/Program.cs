using System;

namespace _02._Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	"Passed!" if the grade is equal or more than 3.00.

            double grade = double.Parse(Console.ReadLine());

            if (grade >= 3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
