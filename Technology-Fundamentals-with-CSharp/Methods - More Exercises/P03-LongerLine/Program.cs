namespace P03_LongerLine
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            Console.WriteLine(FindLongerLine(x1, y1, x2, y2, x3, y3, x4, y4)); 
        }

        public static string FindLongerLine(double x1,
            double y1, double x2, double y2,
            double x3, double y3, double x4, double y4)
        {
            double firstDistance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            double secondDistance = Math.Sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));

            if (firstDistance >= secondDistance)
            {
                return FindClosestPointToCenter(x1, y1, x2, y2);
            }

            else
            {
                return FindClosestPointToCenter(x3, y3, x4, y4);
            }
        }

        public static string FindClosestPointToCenter(double x1, double y1, double x2, double y2)
        {
            double firstPair = Math.Sqrt(x1 * x1) + (y1 * y1);
            double secondPair = Math.Sqrt(x2 * x2) + (y2 * y2);

            return firstPair <= secondPair ? $"({x1}, {y1})({x2}, {y2})" : $"({x2}, {y2})({x1}, {y1})";
        }
    }
}
