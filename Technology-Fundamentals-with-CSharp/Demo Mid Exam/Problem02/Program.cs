namespace Problem02
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var events = Console.ReadLine().Split("|").ToList();
            int energy = 100;
            int coins = 100;

            for (int i = 0; i < events.Count; i++)
            {
                var command = events[i].Split("-", StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "rest":
                        int gainEnergy = int.Parse(command[1]);

                        if (gainEnergy + energy > 100)
                        {
                            gainEnergy = 100 - energy;
                        }
                        
                        energy += gainEnergy;
                        Console.WriteLine($"You gained {gainEnergy} energy.");
                        Console.WriteLine($"Current energy: {energy}.");
                        break;

                    case "order":
                        int gainCoins = int.Parse(command[1]);

                        if (energy >= 30)
                        {
                            energy -= 30;
                            coins += gainCoins;
                            Console.WriteLine($"You earned {gainCoins} coins.");
                        }

                        else
                        {
                            energy += 50;
                            Console.WriteLine("You had to rest!");
                        }
                        break;

                    default:
                        int price = int.Parse(command[1]);
                        coins -= price;

                        if (coins > 0)
                        {
                            Console.WriteLine($"You bought {command[0]}.");
                        }

                        else
                        {
                            Console.WriteLine($"Closed! Cannot afford {command[0]}.");
                            return;
                        }

                        break;
                }
            }

            Console.WriteLine("Day completed!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Energy: {energy}");
        }
    }
}
