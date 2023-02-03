using System;
using System.Collections.Generic;

namespace P04._Students
{
    class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }
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



                if (IsStudentExisting(allStudents, firstName, lastName))
                {
                    //overwrite students info
                    Student existingStudent = GetExistingStudent(allStudents, firstName, lastName);
                    existingStudent.Age = age;
                    existingStudent.HomeTown = homeTown;

                }
                else
                {
                    Student student = new Student(firstName, lastName, age, homeTown);
                    allStudents.Add(student);
                }

                command = Console.ReadLine();
            }

            string cityName = Console.ReadLine();

            List<Student> filteredStudents = allStudents.FindAll(s => s.HomeTown == cityName);

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }

        }

        static Student GetExistingStudent(List<Student> allStudents, string firstName, string lastName)
        {
            foreach (Student student in allStudents)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return student;
                }
            }
            return null;
        }

        static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
