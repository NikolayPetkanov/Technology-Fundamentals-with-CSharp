namespace P01_ForceBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var forceSides = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Lumpawaroo")
                {
                    var result = forceSides
                        .OrderByDescending(s => s.Value.Count)
                        .ThenBy(s => s.Key);

                    foreach (var side in result)
                    {
                        var sortedMembers = side.Value.OrderBy(m => m).ToList();

                        if (sortedMembers.Count == 0)
                        {
                            continue;
                        }

                        Console.WriteLine($"Side: {side.Key}, Members: {sortedMembers.Count}");

                        foreach (var member in sortedMembers)
                        {
                            Console.WriteLine($"! {member}");
                        }
                    }

                    break;
                }

                var command = input.Split(new string[] { " | ", " -> " }, StringSplitOptions.RemoveEmptyEntries);

                if (input.Contains("|"))
                {
                    string currentSide = command[0];
                    string currentMember = command[1];

                    if (!forceSides.ContainsKey(currentSide))
                    {
                        forceSides.Add(currentSide, new List<string>());
                    }

                    if (!forceSides[currentSide].Contains(currentMember) &&
                        !forceSides.Values.Any(s => s.Contains(currentMember)))
                    {
                        forceSides[currentSide].Add(currentMember);
                    }
                }

                else if (input.Contains("->"))
                {
                    string currentMember = command[0];
                    string currentSide = command[1];

                    if (!forceSides.ContainsKey(currentSide))
                    {
                        forceSides.Add(currentSide, new List<string>());
                    }

                    string oldSide = forceSides.FirstOrDefault(s => s.Value.Contains(currentMember)).Key;

                    if (oldSide != null)
                    {
                        forceSides[oldSide].Remove(currentMember);
                    }

                    if (!forceSides[currentSide].Contains(currentMember))
                    {
                        forceSides[currentSide].Add(currentMember);
                        Console.WriteLine($"{currentMember} joins the {currentSide} side!");
                    }
                }
            }
        }
    }
}
