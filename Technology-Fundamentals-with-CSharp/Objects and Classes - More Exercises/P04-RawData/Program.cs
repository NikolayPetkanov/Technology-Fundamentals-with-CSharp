namespace P04_RawData
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < lines; i++)
            {
                var currentCar = Console.ReadLine().Split();
                string model = currentCar[0];
                int engineSpeed = int.Parse(currentCar[1]);
                int enginePower = int.Parse(currentCar[2]);
                int cargoWeight = int.Parse(currentCar[3]);
                string cargoType = currentCar[4];

                var car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType);
                cars.Add(car);
            }

            string type = Console.ReadLine();

            if (type == "fragile")
            {
                var result = cars.Where(x => x.CargoType == type && x.CargoWeight < 1000);

                foreach (var car in result)
                {
                    Console.WriteLine(car.Model);
                }
            }

            else if (type == "flamable")
            {
                var result = cars.Where(x => x.CargoType == type && x.EnginePower > 250);
                foreach (var car in result)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }

    public class Car
    {
        public string Model { get; set; }

        public int EngineSpeed { get; set; }

        public int EnginePower { get; set; }

        public int CargoWeight { get; set; }

        public string CargoType { get; set; }

        public Car(string model, int engineSpeed, int enginePower,
            int cargoWeight, string cargoType)
        {
            Model = model;
            EngineSpeed = engineSpeed;
            EnginePower = enginePower;
            CargoWeight = cargoWeight;
            CargoType = cargoType;
        }
    }
}
