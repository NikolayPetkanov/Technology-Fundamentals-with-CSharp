namespace P04_FloatingEquality
{
    using System;

    public class Program
    {
        public static void Main()
        {
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            decimal secondNumber = decimal.Parse(Console.ReadLine());
            decimal diff = Math.Abs(firstNumber - secondNumber);

            if (diff < 0.000001m)
            {
                Console.WriteLine("True");
            }

            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
