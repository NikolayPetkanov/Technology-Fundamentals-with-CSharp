namespace P03_RecursiveFibonacci
{
    using System;

    public class Program
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            long prevNumber = 1;
            long number = 1;
            long sum = 0;
            n--;

            for (int i = 0; i < n - 1; i++)
            {
                sum = prevNumber + number;
                prevNumber = number;
                number = sum;
            }

            if (n == 0 || n == 1)
            {
                Console.WriteLine(number);
            }

            else
            {
                Console.WriteLine(sum);
            }
        }
    }
}
