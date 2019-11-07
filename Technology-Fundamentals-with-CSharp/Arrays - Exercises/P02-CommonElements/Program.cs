namespace P02_CommonElements
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();
            int smallestLength = Math.Abs(firstArray.Length - secondArray.Length);

            for (int i = 0; i < firstArray.Length; i++)
            {
                for (int j = 0; j < secondArray.Length; j++)
                {
                    if (secondArray[j] == firstArray[i])
                    {
                        Console.Write(secondArray[j] + " ");
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
