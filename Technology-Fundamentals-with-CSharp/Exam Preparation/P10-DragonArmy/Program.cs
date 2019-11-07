namespace P10_DragonArmy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var dragons = new Dictionary<string, List<Dragon>>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine().Split();

                string type = input[0];
                string name = input[1];

                int damage = input[2] == "null" ? 45 : int.Parse(input[2]);
                int health = input[3] == "null" ? 250 : int.Parse(input[3]);
                int armor = input[4] == "null" ? 10 : int.Parse(input[4]);

                var dragon = new Dragon(name, damage, health, armor);
                
                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new List<Dragon>());
                }

                int index = dragons[type].FindIndex(d => d.Name == name);

                if (index == -1)
                {
                    dragons[type].Add(dragon);
                }

                else
                {
                    dragons[type][index].Damage = damage;
                    dragons[type][index].Health = health;
                    dragons[type][index].Armor = armor;
                }
            }

            foreach (var type in dragons)
            {
                var sortedDragons = type.Value
                    .OrderBy(d => d.Name);

                double averageDamage = sortedDragons.Average(d => d.Damage);
                double averageHealth = sortedDragons.Average(d => d.Health);
                double averageArmor = sortedDragons.Average(d => d.Armor);

                Console.WriteLine($"{type.Key}::({averageDamage:F2}/{averageHealth:F2}/{averageArmor:F2})");

                foreach (var dragon in sortedDragons)
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}," +
                        $" health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }
        }
    }

    public class Dragon
    {
        public string Name { get; set; }

        public int Damage { get; set; }

        public int Health { get; set; }

        public int Armor { get; set; }

        public Dragon(string name, int damage, int health, int armor)
        {
            Name = name;
            Damage = damage;
            Health = health;
            Armor = armor;
        }
    }
}
