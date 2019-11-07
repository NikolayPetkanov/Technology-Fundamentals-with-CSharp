namespace P07_MaxSequenceOfEqualElements
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sequence = 1;
            int bestSequence = 1;
            int element = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    sequence++;
                }

                else
                {
                    sequence = 1;
                }

                if (sequence > bestSequence)
                {
                    bestSequence = sequence;
                    element = numbers[i];
                }
            }

            for (int i = 0; i < bestSequence; i++)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();
        }
    }
}
