namespace P05_DragonArmy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            var dragons = new List<Dragon>();

            for (int i = 0; i < lines; i++)
            {
                var currentDragon = Console.ReadLine().Split();
                string type = currentDragon[0];
                string name = currentDragon[1];

                int damage = currentDragon[2] == "null" ? 45 : int.Parse(currentDragon[2]);
                int health = currentDragon[3] == "null" ? 250 : int.Parse(currentDragon[3]);
                int armor = currentDragon[4] == "null" ? 10 : int.Parse(currentDragon[4]);

                var dragon = new Dragon(type, name, damage, health, armor);
                int typeIndex = dragons.FindIndex(x => x.Type == type);
                int nameIndex = dragons.FindIndex(x => x.Name == name);

                if (typeIndex >= 0 && nameIndex >= 0)
                {
                    if (dragons[typeIndex].Type == type && dragons[typeIndex].Name == name)
                    {
                        dragons.RemoveAt(typeIndex);
                        dragons.Insert(typeIndex, dragon);
                    }

                    else if (dragons[nameIndex].Type == type && dragons[nameIndex].Name == name)
                    {
                        dragons.RemoveAt(nameIndex);
                        dragons.Insert(nameIndex, dragon);
                    }

                    else
                    {
                        dragons.Add(dragon);
                    }
                }

                else
                {
                    dragons.Add(dragon);
                }
            }

            var result = dragons.GroupBy(x => x.Type);

            foreach (var dragon in result)
            {
                var colors = dragon
                    .Where(x => x.Type == dragon.Key)
                    .OrderBy(x => x.Name);

                double averageDamage = colors.Select(x => x.Damage).Average();
                double averageHealth = colors.Select(x => x.Health).Average();
                double averageArmor = colors.Select(x => x.Armor).Average();

                Console.WriteLine($"{dragon.Key}::({averageDamage:F2}/" +
                    $"{averageHealth:F2}/{averageArmor:F2})");

                foreach (var type in colors)
                {
                    Console.WriteLine($"-{type.Name} -> damage: {type.Damage}, " +
                        $"health: {type.Health}, armor: {type.Armor}");
                }
            }
        }
    }

    public class Dragon
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public int Damage { get; set; }

        public int Health { get; set; }

        public int Armor { get; set; }

        public Dragon(string type, string name, int damage, int health, int armor)
        {
            Type = type;
            Name = name;
            Damage = damage;
            Health = health;
            Armor = armor;
        }
    }
}
