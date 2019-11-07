namespace P02_FromLeftToTheRight
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class Program
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            BigInteger sum = 0;

            for (int i = 0; i < lines; i++)
            {
                BigInteger[] array = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();

                if (array[0] > array[1])
                {
                    while (array[0] != 0)
                    {
                        sum += (array[0] % 10);
                        array[0] /= 10;
                    }
                }

                else if (array[0] <= array[1])
                {
                    while (array[1] != 0)
                    {
                        sum += (array[1] % 10);
                        array[1] /= 10;
                    }
                }

                if (sum < 0)
                {
                    sum *= -1;
                }

                Console.WriteLine(sum);
                sum = 0;
            }
        }
    }
}
