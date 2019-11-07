namespace P02_CarRace
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var steps = Console.ReadLine().Split().Select(int.Parse).ToList();
            double leftRacer = 0.0;
            double rightRacer = 0.0;

            for (int i = 0; i < steps.Count / 2; i++)
            {
                if (steps[i] == 0)
                {
                    leftRacer *= 0.8;
                }

                else
                {
                    leftRacer += steps[i];
                }
            }

            for (int i = steps.Count - 1; i >= (steps.Count / 2) + 1; i--)
            {
                if (steps[i] == 0)
                {
                    rightRacer *= 0.8;
                }

                else
                {
                    rightRacer += steps[i];
                }
            }

            if (leftRacer < rightRacer)
            {
                Console.WriteLine($"The winner is left with total time: {leftRacer}");
            }

            else if (leftRacer > rightRacer)
            {
                Console.WriteLine($"The winner is right with total time: {rightRacer}");
            }
        }
    }
}
