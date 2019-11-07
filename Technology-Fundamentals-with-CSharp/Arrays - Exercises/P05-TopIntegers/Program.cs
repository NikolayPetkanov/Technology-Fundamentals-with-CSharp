namespace P05_TopIntegers
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        counter++;
                    }

                    else
                    {
                        counter = 0;
                        continue;
                    }
                }

                if (counter == numbers.Length - 1 - i)
                {
                    Console.Write(numbers[i] + " ");
                }

                counter = 0;
            }

            Console.WriteLine();
        }
    }
}
