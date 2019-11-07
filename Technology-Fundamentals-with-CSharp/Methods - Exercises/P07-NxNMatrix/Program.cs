namespace P07_NxNMatrix
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                PrintMatrix(size);
                Console.WriteLine();
            }
        }

        public static void PrintMatrix(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(size + " ");
            }
        }
    }
}
