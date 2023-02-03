using System;
using System.Collections.Generic;

namespace P04._Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            string command = Console.ReadLine();

            List<Student> allStudents = new List<Student>();

            while (command != "end")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string firstName = cmdArgs[0];
                string lastName = cmdArgs[1];
                int age = int.Parse(cmdArgs[2]);
                string homeTown = cmdArgs[3];

                Student student = new Student();
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;
                }


                allStudents.Add(student);

                command = Console.ReadLine();
            }

            string cityName = Console.ReadLine();

            List<Student> filteredStudents = allStudents.FindAll(s => s.HomeTown == cityName);

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }

        }
    }
}
