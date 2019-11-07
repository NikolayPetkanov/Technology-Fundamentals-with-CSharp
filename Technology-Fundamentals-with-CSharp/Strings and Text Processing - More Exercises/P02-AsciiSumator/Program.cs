namespace P02_AsciiSumator
{
    using System;

    public class Program
    {
        public static void Main()
        {
            char startSymbol = char.Parse(Console.ReadLine());
            char endSymbol = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > startSymbol && input[i] < endSymbol)
                {
                    sum += input[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
