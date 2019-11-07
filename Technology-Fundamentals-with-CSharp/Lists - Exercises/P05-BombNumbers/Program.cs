namespace P05_BombNumbers
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var bombNumber = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber[0])
                {
                    int left = Math.Max(i - bombNumber[1], 0);
                    int right = Math.Min(i + bombNumber[1], numbers.Count - 1);
                    int length = right - left + 1;
                    numbers.RemoveRange(left, length);
                    i = 0;
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
