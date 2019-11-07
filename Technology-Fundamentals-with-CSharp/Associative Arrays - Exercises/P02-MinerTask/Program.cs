namespace P02_MinerTask
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var resources = new Dictionary<string, int>();

            while (true)
            {
                string currentResource = Console.ReadLine();

                if (currentResource == "stop")
                {
                    foreach (var resource in resources)
                    {
                        Console.WriteLine(resource.Key + " -> " + resource.Value);
                    }

                    break;
                }

                int currentQuantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(currentResource))
                {
                    resources[currentResource] = 0;
                }

                resources[currentResource] += currentQuantity;
            }
        }
    }
}
