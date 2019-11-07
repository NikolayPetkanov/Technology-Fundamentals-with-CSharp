namespace P03_HouseParty
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            var partyList = new List<string>();

            for (int i = 0; i < lines; i++)
            {
                string[] message = Console.ReadLine().Split();

                if (message[2] == "going!")
                {
                    if (partyList.Contains(message[0]))
                    {
                        Console.WriteLine($"{message[0]} is already in the list!");
                    }

                    else
                    {
                        partyList.Add(message[0]);
                    }
                }

                else
                {
                    if (!partyList.Contains(message[0]))
                    {
                        Console.WriteLine($"{message[0]} is not in the list!");
                    }

                    else
                    {
                        partyList.Remove(message[0]);
                    }
                }
            }

            foreach (var name in partyList)
            {
                Console.WriteLine(name);
            }
        }
    }
}
