namespace P02_CenterPoint
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2= double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine(FindClosestPointToCenter(x1, y1, x2, y2));
        }

        public static string FindClosestPointToCenter(double x1, double y1, double x2, double y2)
        {
            double firstDistance = Math.Sqrt(x1 * x1) + (y1 * y1);
            double secondDistance = Math.Sqrt(x2 * x2) + (y2 * y2);
            return firstDistance <= secondDistance ? $"({x1}, {y1})" : $"({x2}, {y2})";
        }
    }
}
