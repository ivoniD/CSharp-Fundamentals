using System;
using System.Collections.Generic;
using System.Linq;

namespace P07._Vehicle_Catalogue
{
    class Truck
    {
        public Truck(string brand, string model, double weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }
        public string Brand { get; set; }

        public string Model { get; set; }

        public double Weight { get; set; }
    }
    class Car
    {
        public Car(string brand, string model, double horseP)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePowers = horseP;
        }
        public string Brand { get; set; }

        public string Model { get; set; }

        public double HorsePowers { get; set; }
    }

    class Catalog
    {
        public Catalog()
        {
            this.cars = new List<Car>();
            this.trucks = new List<Truck>();
        }
        public List<Car> cars { get; set; }

        public List<Truck> trucks { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Catalog CatalogObject = new Catalog();

            while (command != "end")
            {
                string[] cmdArgs = command.Split('/', StringSplitOptions.RemoveEmptyEntries);
                string type = cmdArgs[0];
                string brand = cmdArgs[1];
                string model = cmdArgs[2];
                double horsePowerOrWeight = double.Parse(cmdArgs[3]);
                if (type == "Car")
                {
                    Car newCar = new Car(brand, model, horsePowerOrWeight);
                    CatalogObject.cars.Add(newCar);
                }
                if (type == "Truck")
                {
                    Truck newTruck = new Truck(brand, model, horsePowerOrWeight);
                    // trucks.Add(newTruck);
                    CatalogObject.trucks.Add(newTruck);
                }
                command = Console.ReadLine();
            }

            List<Car> orderedCars = CatalogObject.cars.OrderBy(x => x.Brand).ToList();
            Console.WriteLine("Cars:");
            foreach (Car item in orderedCars)
            {
                Console.WriteLine($"{item.Brand}: {item.Model} - {item.HorsePowers}hp");
            }

            List<Truck> orderedTrucks = CatalogObject.trucks.OrderBy(x => x.Brand).ToList();
            Console.WriteLine("Trucks:");
            foreach (Truck item in orderedTrucks)
            {
                Console.WriteLine($"{item.Brand}: {item.Model} - {item.Weight}kg");
            }
        }
    }
}
