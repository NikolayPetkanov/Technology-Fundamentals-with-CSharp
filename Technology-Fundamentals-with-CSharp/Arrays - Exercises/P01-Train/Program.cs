namespace P01_Train
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int numbersLength = int.Parse(Console.ReadLine());
            int[] numbers = new int[numbersLength];
            int sum = 0;

            for (int i = 0; i < numbersLength; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];
            }

            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine(sum);
        }
    }
}
