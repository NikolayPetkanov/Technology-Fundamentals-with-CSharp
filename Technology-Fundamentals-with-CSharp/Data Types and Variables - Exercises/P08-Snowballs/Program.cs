namespace P08_Snowballs
{
    using System;
    using System.Numerics;

    public class Program
    {
        public static void Main()
        {
            int countSnowballs = int.Parse(Console.ReadLine());
            BigInteger snowballValue = 0;
            BigInteger currentValue = 0;
            int bestSnow = 0;
            int bestTime = 0;
            int bestQuality = 0;

            for (int i = 0; i < countSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                currentValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                if (currentValue > snowballValue)
                {
                    snowballValue = currentValue;
                    bestSnow = snowballSnow;
                    bestTime = snowballTime;
                    bestQuality = snowballQuality;
                }
            }

            Console.WriteLine($"{bestSnow} : {bestTime} = {snowballValue} ({bestQuality})");
        }
    }
}
