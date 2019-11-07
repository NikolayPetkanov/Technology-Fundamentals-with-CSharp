namespace P06_ReversedChars
{
    using System;

    public class Program
    {
        public static void Main()
        {
            char firstInput = char.Parse(Console.ReadLine());
            char secondInput = char.Parse(Console.ReadLine());
            char thirdInput = char.Parse(Console.ReadLine());
            string text = string.Empty;

            text = text + thirdInput + " " + secondInput + " "+ firstInput;
            Console.WriteLine(text);
        }
    }
}
