namespace P09_PokeMon
{
    using System;

    public class Program
    {
        public static void Main()
        {
            long pokePower = long.Parse(Console.ReadLine());
            decimal halfPower = pokePower / 2.0m;
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int targetCount = 0;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                targetCount++;

                if (pokePower == halfPower)
                {
                    if (exhaustionFactor > 0)
                    {
                        pokePower /= exhaustionFactor;
                    }
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(targetCount);
        }
    }
}
