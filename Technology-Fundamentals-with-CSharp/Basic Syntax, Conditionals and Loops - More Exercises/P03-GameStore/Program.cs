namespace P03_GameStore
{
    using System;

    public class Program
    {
        public static void Main()
        {
            decimal currentBalance = decimal.Parse(Console.ReadLine());
            decimal gamePrice = 0.0m;
            decimal totalSpent = 0.0m;
            string game = string.Empty;

            while (game != "Game Time")
            {
                game = Console.ReadLine();

                switch (game)
                {
                    case "OutFall 4":
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99m;
                        break;

                    case "CS: OG":
                        gamePrice = 15.99m;
                        break;

                    case "Zplinter Zell":
                        gamePrice = 19.99m;
                        break;

                    case "Honored 2":
                        gamePrice = 59.99m;
                        break;

                    case "RoverWatch":
                        gamePrice = 29.99m;
                        break;

                    case "Game Time":
                        Console.WriteLine($"Total sum: ${totalSpent:F2}.");
                        Console.WriteLine($"Remaining: ${currentBalance:F2}");
                        return;

                    default:
                        Console.WriteLine("Not found");
                        continue;
                }

                if (currentBalance - gamePrice < 0)
                {
                    Console.WriteLine("Too expensive");
                }

                else
                {
                    currentBalance -= gamePrice;
                    totalSpent += gamePrice;
                    Console.WriteLine($"Bought {game}");
                }

                if (currentBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }
        }
    }
}
