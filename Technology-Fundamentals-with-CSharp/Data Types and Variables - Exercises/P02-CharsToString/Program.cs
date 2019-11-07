namespace P02_CharsToString
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

            text = text + firstInput + secondInput + thirdInput;
            Console.WriteLine(text);
        }
    }
}
