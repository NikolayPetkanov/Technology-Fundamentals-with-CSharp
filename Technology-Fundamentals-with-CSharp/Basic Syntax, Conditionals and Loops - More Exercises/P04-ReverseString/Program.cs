namespace P04_ReverseString
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            char[] cArray = input.ToCharArray();
            string reversedInput = "";

            for (int i = cArray.Length - 1; i >= 0; i--)
            {
                reversedInput += cArray[i];
            }

            Console.WriteLine(reversedInput);
        }
    }
}
