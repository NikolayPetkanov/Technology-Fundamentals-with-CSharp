namespace P06_VehicleCatalogue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var vehicles = new List<Vehicle>();

            while (true)
            {
                var currentVehicle = Console.ReadLine().Split();

                if (currentVehicle[0] == "End")
                {
                    break;
                }

                string type = currentVehicle[0];
                type = currentVehicle[0][0].ToString().ToUpper() + currentVehicle[0].Substring(1);
                string model = currentVehicle[1];
                string colour = currentVehicle[2];
                int horsePower = int.Parse(currentVehicle[3]);

                var car = new Vehicle
                {
                    Type = type,
                    Model = model,
                    Colour = colour,
                    HorsePower = horsePower
                };

                vehicles.Add(car);
            }

            while (true)
            {
                var choosenModel = Console.ReadLine();

                if (choosenModel == "Close the Catalogue")
                {
                    break;
                }

                var vehicle = vehicles.Where(x => x.Model == choosenModel).First();

                Console.WriteLine($"Type: {vehicle.Type}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine($"Color: {vehicle.Colour}");
                Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
            }

            var cars = vehicles.Where(x => x.Type == "Car").ToList();
            var trucks = vehicles.Where(x => x.Type == "Truck").ToList();

            if (cars.Count() > 0)
            {
                Console.WriteLine($"Cars have average horsepower of:" +
                    $" {cars.Select(x => x.HorsePower).Average():F2}.");
            }

            else
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }

            if (trucks.Count() > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of:" +
                    $" {trucks.Select(x => x.HorsePower).Average():F2}.");
            }

            else
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
        }
    }

    public class Vehicle
    {
        public string Type { get; set; }

        public string Model { get; set; }

        public string Colour { get; set; }

        public int HorsePower { get; set; }
    }
}