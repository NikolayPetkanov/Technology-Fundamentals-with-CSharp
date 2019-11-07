namespace P08_LettersChangeNumbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            double totalSum = 0.0;

            foreach (var text in input)
            {
                string digits = text.Substring(1, text.Length - 2);
                double number = double.Parse(digits);
                double secondNumber = 0;

                if (char.IsUpper(text[0]))
                {
                    secondNumber = text[0] + 1 - 65;
                    number /= secondNumber;
                }

                else if (char.IsLower(text[0]))
                {
                    secondNumber = text[0] + 1 - 97;
                    number *= secondNumber;
                }

                if (char.IsUpper(text[text.Length - 1]))
                {
                    secondNumber = text[text.Length - 1] + 1 - 65;
                    number -= secondNumber;
                }

                else if (char.IsLower(text[text.Length - 1]))
                {
                    secondNumber = text[text.Length - 1] + 1 - 97;
                    number += secondNumber;
                }

                totalSum += number;
            }

            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
