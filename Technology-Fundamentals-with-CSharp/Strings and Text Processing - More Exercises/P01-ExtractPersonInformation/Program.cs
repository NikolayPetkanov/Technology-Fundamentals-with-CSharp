namespace P01_ExtractPersonInformation
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            string firstRegex = @"[@\|](\w+)[@\|]";
            string secondRegex = @"[#*](\d+)[#\*]";
            Match matchedPerson;
            Match matchedAge;

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();

                matchedPerson = Regex.Match(input, firstRegex);
                matchedAge = Regex.Match(input, secondRegex);

                string name = matchedPerson.Groups[1]
                    .Value.ToString().Replace("@", "").Replace("|", "");

                string age = matchedAge.Groups[1]
                    .Value.ToString().Replace("#", "").Replace("*", "");

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
