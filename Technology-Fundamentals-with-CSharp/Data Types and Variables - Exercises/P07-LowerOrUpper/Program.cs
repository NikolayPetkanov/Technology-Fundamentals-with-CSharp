namespace P07_LowerOrUpper
{
    using System;

    public class Program
    {
        public static void Main()
        {
            char letter = char.Parse(Console.ReadLine());

            if (letter >= 65 && letter <= 90)
            {
                Console.WriteLine("upper-case");
            }

            else if (letter >= 97 && letter <= 122)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
