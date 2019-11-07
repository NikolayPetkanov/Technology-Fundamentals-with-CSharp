namespace P03_SpeedRacing
{
    using System;
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
                double totalFuel = double.Parse(currentCar[1]);
                double litersPerKm = double.Parse(currentCar[2]);

                var car = new Car(model, totalFuel, litersPerKm);
                cars.Add(car);
            }

            while (true)
            {
                var command = Console.ReadLine().Split();

                if (command[0] == "End")
                {
                    foreach (var car in cars)
                    {
                        Console.WriteLine($"{car.Model} {car.TotalFuel:F2} {car.Distance}");
                    }

                    break;
                }

                string model = command[1];
                int kilometers = int.Parse(command[2]);

                MoveCar(model, kilometers, cars);
            }
        }

        public static void MoveCar(string model, int kilometers, List<Car> cars)
        {
            var car = cars.Find(x => x.Model == model);

            if (kilometers * car.LitersPerKm <= car.TotalFuel)
            {
                car.TotalFuel -= kilometers * car.LitersPerKm;
                car.Distance += kilometers;
            }

            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }

    public class Car
    {
        public string Model { get; set; }

        public double TotalFuel { get; set; }

        public double LitersPerKm { get; set; }

        public int Distance { get; set; }

        public Car(string model, double totalFuel, double litersPerKm)
        {
            Model = model;
            TotalFuel = totalFuel;
            LitersPerKm = litersPerKm;
        }
    }
}
