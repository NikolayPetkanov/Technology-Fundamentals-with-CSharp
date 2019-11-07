namespace P03_LettersChangeNumbers
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string pattern = @"(?<firstLetter>[A-Za-z])(?<number>\d+)(?<secondLetter>[A-Za-z])";
            double finalNumber = 0.0;
            string input = Console.ReadLine();

            MatchCollection matchedStrings = Regex.Matches(input, pattern);

            foreach (Match match in matchedStrings)
            {
                char firstLetter = char.Parse(match.Groups["firstLetter"].Value);
                char secondLetter = char.Parse(match.Groups["secondLetter"].Value);
                double number = double.Parse(match.Groups["number"].Value);

                if (char.IsUpper(firstLetter))
                {
                    double secondNumber = firstLetter - 64;
                    number /= secondNumber;
                }

                else if (char.IsLower(firstLetter))
                {
                    double secondNumber = firstLetter - 96;
                    number *= secondNumber;
                }

                if (char.IsUpper(secondLetter))
                {
                    double secondNumber = secondLetter - 64;
                    number -= secondNumber;
                }

                else if (char.IsLower(secondLetter))
                {
                    double secondNumber = secondLetter - 96;
                    number += secondNumber;
                }

                finalNumber += number;
            }

            Console.WriteLine($"{finalNumber:F2}");
        }
    }
}
