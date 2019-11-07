namespace P05_AddAndSubstract
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int sum = SumNumbers(firstNumber, secondNumber);
            int substraction = SubstractNumbers(sum, thirdNumber);

            Console.WriteLine(substraction);
        }

        public static int SumNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static int SubstractNumbers(int sum, int thirdNumber)
        {
            return sum - thirdNumber;
        }
    }
}

