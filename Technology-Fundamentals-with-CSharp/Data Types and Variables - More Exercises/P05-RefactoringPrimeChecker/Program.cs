namespace P05_RefactoringPrimeChecker
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 2; i <= number; i++)
            {
                bool prime = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }

                Console.WriteLine($"{i} -> {prime.ToString().ToLower()}");
            }
        }
    }
}
