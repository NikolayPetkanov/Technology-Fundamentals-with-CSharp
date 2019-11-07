namespace P06_EqualSums
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            bool equal = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                leftSum = 0;
                rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += numbers[j];
                }

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    equal = true;
                    return;
                }
            }

            if (!equal)
            {
                Console.WriteLine("no");
            }
        }
    }
}
