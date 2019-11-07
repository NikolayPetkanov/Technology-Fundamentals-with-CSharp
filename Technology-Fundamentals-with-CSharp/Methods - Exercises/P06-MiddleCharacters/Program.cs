namespace P06_MiddleCharacters
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string symbols = Console.ReadLine();
            Console.WriteLine(PrintMiddleCharacters(symbols));
        }

        public static string PrintMiddleCharacters(string symbols)
        {
            string middleChars = string.Empty;

            if (symbols.Length % 2 == 1)
            {
                middleChars += symbols[symbols.Length / 2];
            }

            else
            {
                middleChars += symbols[(symbols.Length / 2) - 1];
                middleChars += symbols[symbols.Length / 2];
            }

            return middleChars;
        }
    }
}
