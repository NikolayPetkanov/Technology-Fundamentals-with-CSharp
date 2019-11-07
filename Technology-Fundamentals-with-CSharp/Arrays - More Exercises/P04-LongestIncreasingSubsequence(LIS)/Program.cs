namespace P04_LongestIncreasingSubsequence_LIS_
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] length = new int[numbers.Length];
            int[] prev = new int[numbers.Length];
            int maxLength = 0;
            int lastIndex = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                length[i] = 1;
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] < numbers[i] && length[j] >= length[i])
                    {
                        length[i] = 1 + length[j];
                        prev[i] = j;
                    }
                }

                if (length[i] > maxLength)
                {
                    maxLength = length[i];
                    lastIndex = i;
                }
            }

            List<int> longestSeq = new List<int>();

            for (int i = 0; i < maxLength; i++)
            {
                longestSeq.Add(numbers[lastIndex]);
                lastIndex = prev[lastIndex];
            }

            longestSeq.Reverse();
            Console.WriteLine(string.Join(" ", longestSeq));
        }
    }
}
