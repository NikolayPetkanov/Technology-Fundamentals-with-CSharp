namespace P01_SortNumbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int numberOne = int.MinValue;
            int numberTwo = 0;
            int numberThree = 0;
            int firstNumber = int.Parse(Console.ReadLine());
            numberOne = firstNumber;
            int secondNumber = int.Parse(Console.ReadLine());

            if (secondNumber > numberOne)
            {
                numberOne = secondNumber;
                numberTwo = firstNumber;
            }

            else
            {
                numberTwo = secondNumber;
            }

            int thirdNumber = int.Parse(Console.ReadLine());

            if (thirdNumber > numberOne)
            {
                numberOne = thirdNumber;

                if (firstNumber > secondNumber)
                {
                    numberTwo = firstNumber;
                    numberThree = secondNumber;
                }

                else
                {
                    numberTwo = secondNumber;
                    numberThree = firstNumber;
                }
            }

            else if (thirdNumber > numberTwo)
            {
                numberTwo = thirdNumber;

                if (numberOne == firstNumber)
                {
                    numberThree = secondNumber;
                }

                else if (numberOne == secondNumber)
                {
                    numberThree = firstNumber;
                }
            }

            else
            {
                numberThree = thirdNumber;
            }

            Console.WriteLine(numberOne);
            Console.WriteLine(numberTwo);
            Console.WriteLine(numberThree);
        }
    }
}
