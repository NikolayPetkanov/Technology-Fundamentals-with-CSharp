namespace P01_Messaging
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();
            var text = new List<string>(input.Select(c => c.ToString()));
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                while (numbers[i] != 0)
                {
                    sum += (numbers[i] % 10);
                    numbers[i] /= 10;
                }

                if (sum > text.Count)
                {
                    sum -= (text.Count);
                }

                Console.Write(text[sum]);
                text.RemoveAt(sum);
                sum = 0;
            }

            Console.WriteLine();
        }
    }
}
