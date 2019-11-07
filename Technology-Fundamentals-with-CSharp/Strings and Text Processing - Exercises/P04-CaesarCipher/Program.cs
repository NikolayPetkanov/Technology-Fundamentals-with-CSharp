using System;
using System.Text;

namespace P04_CaesarCipher
{
    public class Program
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            foreach (var letter in text)
            {
                result.Append((char)(letter + 3));
            }

            Console.WriteLine(result);
        }
    }
}

