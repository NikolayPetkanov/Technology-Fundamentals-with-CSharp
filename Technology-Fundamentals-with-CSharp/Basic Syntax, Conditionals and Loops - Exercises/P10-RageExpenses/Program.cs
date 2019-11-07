namespace P10_RageExpenses
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            decimal headsetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal displayPrice = decimal.Parse(Console.ReadLine());
            decimal totalSum = 0.0m;
            int counter = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0 || i % 3 == 0)
                {
                    if (i % 6 == 0)
                    {
                        totalSum += keyboardPrice;
                        counter++;
                        if (counter % 2 == 0)
                        {
                            totalSum += displayPrice;
                        }
                    }

                    if (i % 2 == 0)
                    {
                        totalSum += headsetPrice;
                    }

                    if (i % 3 == 0)
                    {
                        totalSum += mousePrice;
                    }
                }
            }

            Console.WriteLine($"Rage expenses: {totalSum:F2} lv.");
        }
    }
}
