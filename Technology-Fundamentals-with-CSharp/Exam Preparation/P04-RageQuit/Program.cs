namespace P04_RageQuit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string symbolsPattern = @"[^\d]+";
            string countPattern = @"\d+";

            string input = Console.ReadLine().ToUpper();
            StringBuilder message = new StringBuilder();
            var uniqueSymbols = new List<char>();

            MatchCollection matchedSymbols = Regex.Matches(input, symbolsPattern);
            MatchCollection matchedCounts = Regex.Matches(input, countPattern);

            for (int i = 0; i < matchedSymbols.Count; i++)
            {
                string text = matchedSymbols[i].Value;
                int count = int.Parse(matchedCounts[i].Value);

                message.Insert(message.Length, text, count);

                if (count > 0)
                {
                    foreach (var character in text)
                    {
                        if (!uniqueSymbols.Contains(character))
                        {
                            uniqueSymbols.Add(character);
                        }
                    }
                }
            }

            Console.WriteLine($"Unique symbols used: {uniqueSymbols.Count}");
            Console.WriteLine(message);
        }
    }
}
