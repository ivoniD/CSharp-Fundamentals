using System;

namespace Fundamentals_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	student name    •	age     •  average grade. 
            //"Name: {student name}, Age: {student age}, Grade: {student grade}".

            string studentName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {studentName}, Age: {age}, Grade: {averageGrade:f2}");

        }
    }
}
