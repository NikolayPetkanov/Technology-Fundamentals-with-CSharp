namespace P02_Deciphering
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string pattern = @"^[d-z{}|#]+$";

            string firstLine = Console.ReadLine();
            var secondLine = Console.ReadLine().Split();

            Match validText = Regex.Match(firstLine, pattern);

            if (validText.Success == false)
            {
                Console.WriteLine("This is not the book you are looking for.");
                return;
            }

            char[] textInArray = firstLine.ToCharArray();

            for (int i = 0; i < textInArray.Length; i++)
            {
                textInArray[i] -= (char)3;
            }

            string result = new string(textInArray);
            string replacedText = result.Replace(secondLine[0], secondLine[1]);
            Console.WriteLine(replacedText);
        }
    }
}
