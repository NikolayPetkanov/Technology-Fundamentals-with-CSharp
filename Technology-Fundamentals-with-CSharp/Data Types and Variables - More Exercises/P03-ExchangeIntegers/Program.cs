namespace P03_ExchangeIntegers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Before:");
            Console.WriteLine("a = " + firstNumber);
            Console.WriteLine("b = " + secondNumber);

            int temporaryNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temporaryNumber;

            Console.WriteLine("After:");
            Console.WriteLine("a = " + firstNumber);
            Console.WriteLine("b = " + secondNumber);
        }
    }
}
