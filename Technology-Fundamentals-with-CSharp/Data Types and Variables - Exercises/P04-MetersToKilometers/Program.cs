namespace P04_MetersToKilometers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int meters = int.Parse(Console.ReadLine());
            double km = meters / 1000.0;
            Console.WriteLine($"{km:f2}");
        }
    }
}
