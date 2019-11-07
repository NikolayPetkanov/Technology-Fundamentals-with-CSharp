namespace P01_ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string message = Console.ReadLine();
            string regex = @"\s([0-9A-Za-z]+(-*|_*|\.*)[0-9a-zA-Z]*@[a-z]+-*[a-z]*(\.[a-z]+)+\b)";
            MatchCollection matchesEmails = Regex.Matches(message, regex);

            foreach (Match email in matchesEmails)
            {
                Console.WriteLine(email.Groups[1].Value);
            }
        }
    }
}
