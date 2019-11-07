namespace P01_Train
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int wagonCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "end")
                {
                    break;
                }

                else if (command[0] == "Add")
                {
                    wagons.Add(int.Parse(command[1]));
                }

                else
                {
                    int passengers = int.Parse(command[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= wagonCapacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
