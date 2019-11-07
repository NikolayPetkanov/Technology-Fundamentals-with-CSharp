namespace P09_Snowwhite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var dwarves = new List<Dwarf>();
            var ColorsCount = new Dictionary<string, int>();

            while (true)
            {
                var input = Console.ReadLine().Split(" <:> ");

                if (input[0] == "Once upon a time")
                {
                    foreach (var dwarf in dwarves)
                    {
                        foreach (var color in ColorsCount)
                        {
                            if (dwarf.HatColor == color.Key)
                            {
                                dwarf.ColorCount = color.Value;
                            }
                        }
                    }

                    var result = dwarves
                        .OrderByDescending(d => d.Physics)
                        .ThenByDescending(d => d.ColorCount);

                    foreach (var dwarf in result)
                    {
                        Console.WriteLine($"({dwarf.HatColor}) {dwarf.Name} <-> {dwarf.Physics}");
                    }

                    break;
                }

                string name = input[0];
                string hatColor = input[1];
                int physics = int.Parse(input[2]);

                var currentDwarf = new Dwarf(name, hatColor, physics);

                int index = dwarves.FindIndex(d => d.Name == name);

                if (index == -1)
                {
                    dwarves.Add(currentDwarf);
                }

                else if (dwarves[index].HatColor != hatColor)
                {
                    dwarves.Add(currentDwarf);
                }

                else if (dwarves[index].Physics < physics)
                {
                    dwarves[index].Physics = physics;
                    continue;
                }

                if (!ColorsCount.ContainsKey(hatColor))
                {
                    ColorsCount.Add(hatColor, 0);
                }

                ColorsCount[hatColor]++;
            }
        }
    }

    public class Dwarf
    {
        public string Name { get; set; }

        public string HatColor { get; set; }

        public int Physics { get; set; }

        public int ColorCount { get; set; }

        public Dwarf(string name, string hatColor, int physics)
        {
            Name = name;
            HatColor = hatColor;
            Physics = physics;
        }
    }
}
