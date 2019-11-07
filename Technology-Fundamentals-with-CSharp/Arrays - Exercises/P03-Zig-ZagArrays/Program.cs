namespace P03_Zig_ZagArrays
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            int[] firstArray = new int[lines];
            int[] secondArray = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                int[] currentArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    firstArray[i] = currentArray[0];
                    secondArray[i] = currentArray[1];
                }

                else
                {
                    firstArray[i] = currentArray[1];
                    secondArray[i] = currentArray[0];
                }
            }

            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
