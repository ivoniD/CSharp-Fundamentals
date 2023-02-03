using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> persons = new List<Person>();

            string[] cmdArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (cmdArg[0] != "End")
            {

                string name = cmdArg[0];
                string id = cmdArg[1];
                int age = int.Parse(cmdArg[2]);

                if (persons.Any(x => x.ID == id))
                {
                    Person currentPerson = persons.First(x => x.ID == id);

                    currentPerson.Name = name;
                    currentPerson.Age = age;
                }
                else
                {
                    Person newPerson = new Person(name, id, age);
                    persons.Add(newPerson);
                }



                cmdArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            persons = persons.OrderBy(x => x.Age).ToList();

            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }

        }
    }
    class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.ID = id;
            this.Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }


        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }

    }
}