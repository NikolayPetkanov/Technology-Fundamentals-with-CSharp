namespace P02_DungeonestDark
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int health = 100;
            int coins = 0;

            var dungeonsRooms = Console.ReadLine().Split('|');
            int counter = 0;

            for (int i = 0; i < dungeonsRooms.Length; i++)
            {
                var command = dungeonsRooms[i].Split();
                counter = i + 1;

                if (command[0] == "potion")
                {
                    int potion = int.Parse(command[1]);

                    if (health + potion >= 100)
                    {
                        potion = 100 - health;
                        health = 100;
                    }

                    else
                    {
                        health += potion;
                    }

                    Console.WriteLine($"You healed for {potion} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }

                else if (command[0] == "chest")
                {
                    int foundedCoins = int.Parse(command[1]);
                    coins += foundedCoins;
                    Console.WriteLine($"You found {foundedCoins} coins.");
                }

                else
                {
                    string monster = command[0];
                    int attack = int.Parse(command[1]);

                    if (health - attack > 0)
                    {
                        health -= attack;
                        Console.WriteLine($"You slayed {monster}.");
                    }

                    else
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {counter}");
                        return;
                    }
                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
