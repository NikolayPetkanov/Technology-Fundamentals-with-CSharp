namespace P05_MultiplicationSign
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = new int[3];
            numbers[0] = int.Parse(Console.ReadLine());
            numbers[1] = int.Parse(Console.ReadLine());
            numbers[2] = int.Parse(Console.ReadLine());
            FindSign(numbers);
        }

        public static void FindSign(int[] numbers)
        {
            int signs = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    Console.WriteLine("zero");
                    return;
                }

                else if (numbers[i] < 0)
                {
                    signs++;
                }
            }

            if (signs % 2 == 0)
            {
                Console.WriteLine("positive");
            }

            else
            {
                Console.WriteLine("negative");
            }
        }
    }
}
