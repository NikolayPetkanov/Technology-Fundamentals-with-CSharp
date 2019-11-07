namespace P08_MOBAChallenger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var playerStats = new List<Player>();

            while (true)
            {
                var input = Console.ReadLine().Split(" -> ");

                if (input[0] == "Season end")
                {
                    var result = playerStats
                        .OrderByDescending(p => p.Positions.Values.Sum())
                        .ThenBy(p => p.Name);

                    foreach (var currentPlayer in result)
                    {
                        var pair = currentPlayer.Positions
                            .OrderByDescending(p => p.Value)
                            .ThenBy(p => p.Key);

                        Console.WriteLine($"{currentPlayer.Name}: {currentPlayer.Positions.Values.Sum()} skill");

                        foreach (var kvp in pair)
                        {
                            Console.WriteLine($"- {kvp.Key} <::> {kvp.Value}");
                        }
                    }

                    break;
                }

                else if (input.Length == 3)
                {
                    string name = input[0];
                    string position = input[1];
                    int points = int.Parse(input[2]);

                    var player = new Player(name, position, points);

                    int index = playerStats.FindIndex(p => p.Name == player.Name);

                    if (index == -1)
                    {
                        playerStats.Add(player);
                    }

                    else if (!playerStats[index].Positions.ContainsKey(position))
                    {
                        playerStats[index].Positions.Add(position, points);
                    }

                    else if (playerStats[index].Positions[position] < points)
                    {
                        playerStats[index].Positions[position] = points;
                    }

                }

                else if (input.Length == 1)
                {
                    var duel = input[0].Split();

                    string firstPlayer = duel[0];
                    string secondPlayer = duel[2];

                    int firstIndex = playerStats.FindIndex(p => p.Name == firstPlayer);
                    int secondIndex = playerStats.FindIndex(p => p.Name == secondPlayer);

                    if (firstIndex > -1 && secondIndex > -1)
                    {
                        bool hasCommon = false;
                        string commonPosition = string.Empty;

                        foreach (var kvp in playerStats[firstIndex].Positions)
                        {
                            if (playerStats[secondIndex].Positions.ContainsKey(kvp.Key))
                            {
                                hasCommon = true;
                                commonPosition = kvp.Key;
                                break;
                            }
                        }

                        if (hasCommon)
                        {
                            if (playerStats[firstIndex].Positions.Values.Sum() >
                                playerStats[secondIndex].Positions.Values.Sum())
                            {
                                playerStats.RemoveAt(secondIndex);
                            }

                            else if (playerStats[firstIndex].Positions.Values.Sum() <
                                playerStats[secondIndex].Positions.Values.Sum())
                            {
                                playerStats.RemoveAt(firstIndex);
                            }
                        }
                    }
                }
            }
        }
    }

    public class Player
    {
        public string Name { get; set; }

        public Dictionary<string, int> Positions { get; set; }

        public Player(string name, string position, int points)
        {
            Name = name;
            Positions = new Dictionary<string, int>();
            Positions.Add(position, points);
        }
    }
}
