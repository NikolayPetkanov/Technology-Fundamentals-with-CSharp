namespace Problem03
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            int currentQuality = 0;
            int bestQuality = int.MinValue;
            double currentAverageQuality = 0.0;
            double bestAverageQuality = 0.0;
            var bestBatch = new List<int>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Bake It!")
                {
                    Console.WriteLine($"Best Batch quality: {bestQuality}");
                    Console.WriteLine(string.Join(" ", bestBatch));
                    break;
                }

                var batch = command.Split("#").Select(int.Parse).ToList();
                currentQuality = batch.Sum();
                currentAverageQuality = batch.Average();

                if (currentQuality > bestQuality)
                {
                    bestQuality = currentQuality;
                    bestAverageQuality = currentAverageQuality;
                    bestBatch = batch;
                }

                else if (currentQuality == bestQuality)
                {
                    if (currentAverageQuality > bestAverageQuality)
                    {
                        bestQuality = currentQuality;
                        bestAverageQuality = currentAverageQuality;
                        bestBatch = batch;
                    }

                    else if (currentAverageQuality == bestAverageQuality)
                    {
                        if (batch.Count < bestBatch.Count)
                        {
                            bestQuality = currentQuality;
                            bestAverageQuality = currentAverageQuality;
                            bestBatch = batch;
                        }
                    }
                }
            }
        }
    }
}
