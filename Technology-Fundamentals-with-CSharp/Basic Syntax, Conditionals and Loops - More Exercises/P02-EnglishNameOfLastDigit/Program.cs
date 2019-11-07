namespace P02_EnglishNameOfLastDigit
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int digit = number % 10;
            string englishName = string.Empty;

            switch (digit)
            {
                case 0:
                    englishName = "zero";
                    break;

                case 1:
                    englishName = "one";
                    break;

                case 2:
                    englishName = "two";
                    break;

                case 3:
                    englishName = "three";
                    break;

                case 4:
                    englishName = "four";
                    break;

                case 5:
                    englishName = "five";
                    break;

                case 6:
                    englishName = "six";
                    break;

                case 7:
                    englishName = "seven";
                    break;

                case 8:
                    englishName = "eight";
                    break;

                case 9:
                    englishName = "nine";
                    break;
            }

            Console.WriteLine(englishName);
        }
    }
}
