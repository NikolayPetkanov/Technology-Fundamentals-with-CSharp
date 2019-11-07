namespace P03_CharactersInRange
{
    using System;

    public class Program
    {
        public static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            char[] array = PrintChars(firstChar, secondChar);
            Console.WriteLine(string.Join(" ", array));
        }

        public static char[] PrintChars(char firstChar, char secondChar)
        {
            char[] symbols = new char[Math.Abs(secondChar - firstChar) - 1];
            int counter = 0;
            int start = Math.Min(firstChar, secondChar);
            int end = Math.Max(firstChar, secondChar);

            for (int i = start + 1; i < end; i++)
            {
                symbols[counter] = (char)i;
                counter++;
            }

            return symbols;
        }
    }
}
