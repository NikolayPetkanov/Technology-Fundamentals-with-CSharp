namespace P08_FactorialDivision
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            double result = (double)FindFactorial(firstNumber) / FindFactorial(secondNumber);
            Console.WriteLine($"{result:F2}");
        }

        public static long FindFactorial(int number)
        {
            long factorial = 1;

            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
