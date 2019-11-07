namespace P02_Division
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int division = 0;

            if (number % 2 == 0 || number % 3 == 0 || number % 7 == 0)
            {
                if (number % 10 == 0)
                {
                    division = 10;
                }

                else if (number % 7 == 0)
                {
                    division = 7;
                }

                else if (number % 3 == 0)
                {
                    if ((number % 3 == 0 && number % 2 == 0) || number % 6 == 0)
                    {
                        division = 6;
                    }

                    else if (number % 3 == 0)
                    {
                        division = 3;
                    }
                }

                else if (number % 2 == 0)
                {
                    division = 2;
                }

                Console.WriteLine($"The number is divisible by {division}");
            }

            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
