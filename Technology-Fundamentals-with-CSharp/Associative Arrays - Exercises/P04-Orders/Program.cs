namespace P04_Orders
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var products = new Dictionary<string, int>();
            var prices = new List<decimal>();

            while (true)
            {
                var currentProduct = Console.ReadLine().Split().ToArray();

                if (currentProduct[0] == "buy")
                {
                    int counter = 0;

                    foreach (var product in products)
                    {
                        Console.WriteLine($"{product.Key} -> {product.Value * prices[counter]}");
                        counter++;
                    }

                    break;
                }

                decimal price = decimal.Parse(currentProduct[1]);
                int quantity = int.Parse(currentProduct[2]);

                if (!products.ContainsKey(currentProduct[0]))
                {
                    products[currentProduct[0]] = quantity;
                    prices.Add(price);
                }

                else
                {
                    int index = Array.IndexOf(products.Keys.ToArray(), currentProduct[0]);
                    products[currentProduct[0]] += quantity;
                    prices.RemoveAt(index);
                    prices.Insert(index, price);
                }
            }
        }
    }
}
