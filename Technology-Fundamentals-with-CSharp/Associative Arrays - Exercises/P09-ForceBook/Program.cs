namespace P09_ForceBook
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            var forces = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                var command = input
                    .Split(new string[] { " | ", " -> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (command.Count == 1)
                {
                    var result = forces
                       .OrderByDescending(x => x.Value.Count)
                       .ThenBy(x => x.Key);

                    foreach (var force in result)
                    {
                        List<string> forceMembers = force.Value;
                        forceMembers.Sort();

                        if (forceMembers.Count == 0)
                        {
                            continue;
                        }

                        Console.WriteLine($"Side: {force.Key}, Members: {forceMembers.Count}");

                        for (int i = 0; i < forceMembers.Count; i++)
                        {
                            Console.WriteLine("! " + forceMembers[i]);
                        }
                    }

                    break;
                }

                if (input.Contains("|"))
                {
                    forces = CheckMember(command, forces);
                }

                else if (input.Contains("->"))
                {
                    forces = MoveMember(command, forces);
                }
            }
        }

        public static Dictionary<string, List<string>> CheckMember(List<string> command,
            Dictionary<string, List<string>> forces)
        {
            string currentSide = command[0];
            string currentMember = command[1];
            var forceMembers = new List<string>();

            if (!forces.ContainsKey(currentSide))
            {
                forces[currentSide] = new List<string>();
            }

            foreach (var side in forces)
            {
                forceMembers = side.Value;
                if (forceMembers.Contains(currentMember))
                {
                    return forces;
                }
            }

            if (!forces[currentSide].Contains(currentMember))
            {
                forces[currentSide].Add(currentMember);
            }

            return forces;
        }

        public static Dictionary<string, List<string>> MoveMember(List<string> command,
            Dictionary<string, List<string>> forces)
        {
            string currentMember = command[0];
            string currentSide = command[1];
            var forceMembers = new List<string>();

            foreach (var side in forces)
            {
                forceMembers = side.Value;

                if (forceMembers.Contains(currentMember))
                {
                    forceMembers.Remove(currentMember);
                    break;
                }
            }

            if (!forces.ContainsKey(currentSide))
            {
                forces[currentSide] = new List<string>();
            }

            if (!forces[currentSide].Contains(currentMember))
            {
                forces[currentSide].Add(currentMember);
            }

            Console.WriteLine($"{currentMember} joins the {currentSide} side!");
            return forces;
        }
    }
}
