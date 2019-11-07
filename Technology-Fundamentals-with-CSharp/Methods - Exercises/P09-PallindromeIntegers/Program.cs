namespace P09_PalindromeIntegers
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    return;
                }

                char[] number = input.ToArray();
                Console.WriteLine(CheckPalindrome(number));
            }
        }

        public static string CheckPalindrome(char[] number)
        {
            char[] reversedNumber = number.Reverse().ToArray();

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] != reversedNumber[i])
                {
                    return "false";
                }
            }

            return "true";
        }
    }
}
