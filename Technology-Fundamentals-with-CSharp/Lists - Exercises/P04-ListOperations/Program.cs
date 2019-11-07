namespace P04_ListOperations
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "End")
                {
                    break;
                }

                else if (command[0] == "Add")
                {
                    numbers.Add(int.Parse(command[1]));
                }

                else if (command[0] == "Remove")
                {
                    int index = int.Parse(command[1]);

                    if (index >= numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.RemoveAt(index);
                }

                else if (command[0] == "Insert")
                {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);

                    if (index >= numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.Insert(index, number);
                }

                else if (command[0] == "Shift")
                {
                    int iterations = int.Parse(command[2]);

                    if (command[1] == "left")
                    {
                        numbers = PrintLeft(numbers, iterations);
                    }

                    else if (command[1] == "right")
                    {
                        numbers = PrintRight(numbers, iterations);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        public static List<int> PrintLeft(List<int> numbers, int iterations)
        {
            for (int i = 0; i < iterations; i++)
            {
                int firstNumber = numbers[0];

                for (int j = 0; j < numbers.Count - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }

                numbers[numbers.Count - 1] = firstNumber;
            }

            return numbers;
        }

        public static List<int> PrintRight(List<int> numbers, int iterations)
        {
            for (int i = 0; i < iterations; i++)
            {
                int lastNumber = numbers[numbers.Count - 1];

                for (int j = numbers.Count - 1; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];
                }

                numbers[0] = lastNumber;
            }

            return numbers;
        }
    }
}
