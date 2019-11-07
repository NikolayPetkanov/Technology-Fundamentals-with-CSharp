namespace P07_VendingMachine
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string input = "";
            decimal sum = 0.0m;
            decimal coins = 0.0m;
            decimal price = 0.0m;

            while (input != "Start")
            {
                input = Console.ReadLine();
                bool money = decimal.TryParse(input, out coins);

                if (money)
                {
                    if (coins == 0.1m || coins == 0.2m || coins == 0.5m || coins == 1.0m || coins == 2.0m)
                    {
                        sum += coins;
                    }

                    else
                    {
                        Console.WriteLine($"Cannot accept {coins}");
                    }
                }

                else if (input == "Start")
                {
                    break;
                }
            }

            while (input != "End")
            {
                input = Console.ReadLine();

                switch (input)
                {
                    case "Nuts":
                        price = 2.0m;
                        break;

                    case "Water":
                        price = 0.7m;
                        break;

                    case "Crisps":
                        price = 1.5m;
                        break;

                    case "Soda":
                        price = 0.8m;
                        break;

                    case "Coke":
                        price = 1.0m;
                        break;

                    case "End":
                        Console.WriteLine($"Change: {sum:F2}");
                        return;

                    default:
                        Console.WriteLine("Invalid product");
                        continue;
                }

                if (sum - price >= 0.0m)
                {
                    sum -= price;
                    input = char.ToLower(input[0]) + input.Substring(1);
                    Console.WriteLine($"Purchased {input}");
                }

                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
        }
    }
}
