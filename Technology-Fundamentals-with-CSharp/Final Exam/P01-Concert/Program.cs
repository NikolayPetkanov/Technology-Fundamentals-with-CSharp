namespace P01_Concert
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var bands = new Dictionary<string, List<string>>();
            var bandsAndTime = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "start of concert")
                {
                    long totalTime = bandsAndTime.Values.Sum();
                    Console.WriteLine($"Total time: {totalTime}");

                    var sortedBands = bandsAndTime
                        .OrderByDescending(b => b.Value)
                        .ThenBy(b => b.Key);

                    foreach (var band in sortedBands)
                    {
                        Console.WriteLine($"{band.Key} -> {band.Value}");
                    }

                    string choosenBand = Console.ReadLine();

                    Console.WriteLine(choosenBand);

                    var key = bands.FirstOrDefault(b => b.Key == choosenBand);

                    foreach (var member in bands[choosenBand])
                    {
                        Console.WriteLine($"=> {member}");
                    }

                    break;
                }

                var command = input
                    .Split("; ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Add")
                {
                    string name = command[1];
                    var members = command[2].Split(", ").ToList();

                    if (!bands.ContainsKey(name))
                    {
                        bands.Add(name, members);
                        bandsAndTime.Add(name, 0);
                    }

                    else
                    {
                        foreach (var member in members)
                        {
                            if (!bands[name].Contains(member))
                            {
                                bands[name].Add(member);
                            }
                        }
                    }
                }

                else if (command[0] == "Play")
                {
                    string name = command[1];
                    int time = int.Parse(command[2]);

                    if (!bands.ContainsKey(name))
                    {
                        bands.Add(name, new List<string>());
                        bandsAndTime.Add(name, 0);
                    }

                    bandsAndTime[name] += time;
                }
            }
        }
    }
}
