namespace P10_TopNumber
{
    using System;

    public class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            DivisibleByEight(number);
        }

        public static void DivisibleByEight(int number)
        {
            for (int i = 1; i < number; i++)
            {
                int element = i;
                int sum = 0;

                while (element != 0)
                {
                    sum += element % 10;
                    element /= 10;
                }

                if (sum % 8 == 0)
                {
                    bool isOdd = FindOddDigit(i);

                    if (isOdd)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

        public static bool FindOddDigit(int index)
        {
            while (index != 0)
            {
                if ((index % 10) % 2 == 1)
                {
                    return true;
                }

                index /= 10;
            }

            return false;
        }
    }
}
