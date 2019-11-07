namespace P10_LadyBugs
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize];
            int[] bugIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < field.Length; i++)
            {
                if (bugIndexes.Contains(i))
                {
                    field[i] = 1;
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    Console.WriteLine(string.Join(" ", field));
                    break;
                }

                int counter = 0;
                string[] move = command.Split();
                int index = int.Parse(move[0]);
                int flyLength = int.Parse(move[2]);
                int flying = flyLength;

                if (index < 0 || index > field.Length - 1 || field[index] == 0 || flyLength == 0)
                {
                    continue;
                }

                if (move[1] == "right" && flyLength >= 0 || (move[1] == "left" && flyLength < 0) ||
                    move[1] == "left" && flyLength >= 0 || (move[1] == "right" && flyLength < 0))
                {
                    if (move[1] == "left")
                    {
                        flyLength *= -1;
                    }

                    if (index + flyLength > field.Length - 1 || index + flyLength < 0)
                    {
                        field[index] = 0;
                    }

                    else if (field[index + flyLength] == 0)
                    {
                        field[index + flyLength] = 1;
                        field[index] = 0;
                    }

                    else if (field[index + flyLength] == 1)
                    {
                        while (true)
                        {
                            if (index + flyLength < field.Length)
                            {
                                if (field[index + flyLength] == 0)
                                {
                                    field[index + flyLength] = 1;
                                    field[index] = 0;
                                    break;
                                }
                            }

                            else if (index + flyLength + counter > field.Length - 1)
                            {
                                field[index] = 0;
                                break;
                            }

                            if (flyLength > 0)
                            {
                                flyLength += flying;
                            }

                            else
                            {
                                flyLength -= flying;
                            }
                        }
                    }
                }
            }
        }
    }
}
