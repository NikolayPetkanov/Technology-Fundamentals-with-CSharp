namespace P03_LegendaryFarming
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var keyMaterials = new Dictionary<string, int>();
            keyMaterials["shards"] = 0;
            keyMaterials["fragments"] = 0;
            keyMaterials["motes"] = 0;

            var junkMaterials = new Dictionary<string, int>();

            int quantity = 0;

            while (true)
            {
                var materials = Console.ReadLine().Split(" ").ToArray();

                for (int i = 0; i < materials.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        quantity = int.Parse(materials[i]);
                    }

                    else
                    {
                        string currentMaterial = materials[i].ToLower();

                        if (currentMaterial == "shards" ||
                            currentMaterial == "fragments" ||
                            currentMaterial == "motes")
                        {
                            AddKeyMaterial(keyMaterials, currentMaterial, quantity);
                        }

                        else
                        {
                            AddJunkMaterial(junkMaterials, currentMaterial, quantity);
                        }

                        if ((currentMaterial == "shards" ||
                            currentMaterial == "fragments" ||
                            currentMaterial == "motes") &&
                            keyMaterials[currentMaterial] >= 250)
                        {
                            keyMaterials[currentMaterial] -= 250;

                            switch (currentMaterial)
                            {
                                case "shards":
                                    Console.WriteLine("Shadowmourne obtained!");
                                    break;

                                case "fragments":
                                    Console.WriteLine("Valanyr obtained!");
                                    break;

                                case "motes":
                                    Console.WriteLine("Dragonwrath obtained!");
                                    break;
                            }

                            PrintMaterials(keyMaterials, junkMaterials);
                            return;
                        }
                    }
                }
            }
        }

        public static void AddKeyMaterial(Dictionary<string, int> keyMaterials,
            string currentMaterial, int quantity)
        {
            if (!keyMaterials.ContainsKey(currentMaterial))
            {
                keyMaterials[currentMaterial] = 0;
            }

            keyMaterials[currentMaterial] += quantity;
        }

        public static void AddJunkMaterial(Dictionary<string, int> junkMaterials,
            string currentMaterial, int quantity)
        {
            if (!junkMaterials.ContainsKey(currentMaterial))
            {
                junkMaterials[currentMaterial] = 0;
            }

            junkMaterials[currentMaterial] += quantity;
        }

        public static void PrintMaterials(Dictionary<string, int> keyMaterials,
            Dictionary<string, int> junkMaterials)
        {
            keyMaterials = keyMaterials
                 .OrderByDescending(x => x.Value)
                 .ThenBy(x => x.Key)
                 .ToDictionary(x => x.Key, x => x.Value);

            foreach (var material in keyMaterials)
            {
                Console.WriteLine(material.Key + ": " + material.Value);
            }

            junkMaterials = junkMaterials
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var material in junkMaterials)
            {
                Console.WriteLine(material.Key + ": " + material.Value);
            }
        }
    }
}
