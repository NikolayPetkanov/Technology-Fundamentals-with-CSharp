namespace P04_Snowwhite
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var dwarves = new List<Dwarf>();
            var colorsCount = new Dictionary<string, int>();

            while (true)
            {
                var currentDwarf = Console.ReadLine()
                    .Split(" <:> ");

                if (currentDwarf[0] == "Once upon a time")
                {
                    foreach (var unit in dwarves)
                    {
                        foreach (var color in colorsCount)
                        {
                            if (unit.HatColor == color.Key)
                            {
                                unit.ColorCount = color.Value;
                            }
                        }
                    }

                    var result = dwarves
                        .OrderByDescending(x => x.Physics)
                        .ThenByDescending(x => x.ColorCount);

                    foreach (var person in result)
                    {
                        Console.WriteLine($"({person.HatColor}) {person.Name} <-> {person.Physics}");
                    }

                    break;
                }

                string dwarfName = currentDwarf[0];
                string dwarfHatColor = currentDwarf[1];
                int dwarfPhysics = int.Parse(currentDwarf[2]);

                var dwarf = new Dwarf(dwarfName, dwarfHatColor, dwarfPhysics);

                int index = dwarves.FindIndex(x => x.Name == dwarfName);

                if (index >= 0)
                {
                    if (dwarves[index].HatColor != dwarfHatColor)
                    {
                        dwarves.Add(dwarf);
                    }

                    else if (dwarves[index].Physics < dwarfPhysics)
                    {
                        dwarves[index].Physics = dwarfPhysics;
                        continue;
                    }
                }

                else
                {
                    dwarves.Add(dwarf);
                }

                if (!colorsCount.ContainsKey(dwarfHatColor))
                {
                    colorsCount.Add(dwarfHatColor, 0);
                }

                colorsCount[dwarfHatColor]++;
            }
        }
    }

    public class Dwarf
    {
        public string Name { get; set; }

        public string HatColor { get; set; }

        public int Physics { get; set; }

        public int ColorCount { get; set; }

        public Dwarf (string name, string color, int physics)
        {
            Name = name;
            HatColor = color;
            Physics = physics;
        }
    }
}
