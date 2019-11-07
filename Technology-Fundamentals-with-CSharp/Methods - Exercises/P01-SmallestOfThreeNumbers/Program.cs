namespace P01_SmallestOfThreeNumbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int smallerNumber = FindSmallerNumber(firstNumber, secondNumber);
            int smallestNumber = FindSmallerNumber(smallerNumber, thirdNumber);

            Console.WriteLine(smallestNumber);
        }

        public static int FindSmallerNumber(int firstNumber, int secondNumber)
        {
            return firstNumber <= secondNumber ? firstNumber : secondNumber;
        }
    }
}
