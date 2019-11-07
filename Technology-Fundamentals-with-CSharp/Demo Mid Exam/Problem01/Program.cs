namespace Problem01
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            decimal flourPrice = decimal.Parse(Console.ReadLine());
            decimal eggPrice = decimal.Parse(Console.ReadLine());
            decimal apronPrice = decimal.Parse(Console.ReadLine());

            decimal totalPrice = 0.0m;
            totalPrice += (flourPrice * (students - (students / 5)));
            totalPrice += (eggPrice * 10 * students);
            totalPrice += (apronPrice * (students + Math.Ceiling(students / 5.0m)));

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Items purchased for {totalPrice:F2}$.");
            }

            else
            {
                Console.WriteLine($"{(totalPrice - budget):F2}$ more needed.");
            }
        }
    }
}
