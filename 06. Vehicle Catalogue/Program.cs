namespace SandBox
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class EntryPoint
    {

        internal enum VehicleType
        {
            Car,
            Truck
        }

        internal class Vehicle
        {
            public Vehicle(VehicleType type, string model, string color, int horsepower)
            {
                this.Type = type;
                this.Model = model;
                this.Color = color;
                this.Horsepower = horsepower;
            }

            public VehicleType Type { get; private set; }
            public string Model { get; private set; }
            public string Color { get; private set; }
            public int Horsepower { get; private set; }

            public override string ToString()
            {
                StringBuilder builder = new StringBuilder();
                builder.AppendLine($"Type: {this.Type}");
                builder.AppendLine($"Model: {this.Model}");
                builder.AppendLine($"Color: {this.Color}");
                builder.AppendLine($"Horsepower: {this.Horsepower}");

                return builder.ToString().TrimEnd();
            }
        }

        public static void Main()
        {

            List<Vehicle> vehicles = new List<Vehicle>();

            while (true)
            {
                string[] inputArgs = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (inputArgs[0] == "End")
                    break;

                VehicleType vehicleType;
                bool isVehicleTypeParseSuccessful = Enum.TryParse(inputArgs[0], true, out vehicleType);

                if (isVehicleTypeParseSuccessful)
                {

                    string vehicleModel = inputArgs[1];
                    string vehicleColor = inputArgs[2];
                    int vehicleHorsepower = int.Parse(inputArgs[3]);

                    Vehicle currentVehicle = new Vehicle(vehicleType, vehicleModel, vehicleColor, vehicleHorsepower);
                    vehicles.Add(currentVehicle);
                }
            }

            while (true)
            {
                string inputArg = Console.ReadLine();

                if (inputArg == "Close the Catalogue")
                    break;

                Vehicle desiredVehicle = vehicles.FirstOrDefault(x => x.Model == inputArg);
                Console.WriteLine(desiredVehicle);
            }

            // these have to be materialized
            // or use .Count() on IEnumerable<Vehicle> 
            var cars = vehicles
                .Where(x => x.Type == VehicleType.Car)
                .ToList();

            var trucks = vehicles
                .Where(x => x.Type == VehicleType.Truck)
                .ToList();

            double carsAvgHorsepower = cars.Count > 0 ? cars.Average(x => x.Horsepower) : 0.0;
            double trucksAvgHorsepower = trucks.Count > 0 ? trucks.Average(x => x.Horsepower) : 0.0;

            Console.WriteLine($"Cars have average horsepower of: {carsAvgHorsepower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAvgHorsepower:f2}.");
        }
    }
}