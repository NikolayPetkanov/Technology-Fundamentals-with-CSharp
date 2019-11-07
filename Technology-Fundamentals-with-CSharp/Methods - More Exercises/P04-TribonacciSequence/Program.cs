namespace P04_TribonacciSequence
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int[] sequence = new int[4];
            sequence[0] = 0;
            sequence[1] = 0;
            sequence[2] = 1;
            PrintTribonacciSequence(num, sequence);
        }

        public static void PrintTribonacciSequence(int num, int[] sequence)
        {
            for (int i = 0; i < num; i++)
            {
                sequence[3] = sequence[0] + sequence[1] + sequence[2];
                Console.Write($"{sequence[2]} ");
                sequence[0] = sequence[1];
                sequence[1] = sequence[2];
                sequence[2] = sequence[3];
            }

            Console.WriteLine();
        }
    }
}
