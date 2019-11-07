namespace P02_CharacterMultiplier
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            string firstWord = input[0];
            string secondWord = string.Empty;

            if (input.Length > 1)
            {
                secondWord = input[1];
            }
            
            int length = Math.Min(firstWord.Length, secondWord.Length);
            int sum = 0;

            for (int i = 0; i < length; i++)
            {
                sum += (firstWord[i] * secondWord[i]);
            }

            if (firstWord.Length > secondWord.Length)
            {
                for (int i = length; i < firstWord.Length; i++)
                {
                    sum += firstWord[i];
                }
            }

            else if (firstWord.Length < secondWord.Length)
            {
                for (int i = length; i < secondWord.Length; i++)
                {
                    sum += secondWord[i];
                }
            }

            if (sum > 0)
            {
                Console.WriteLine(sum);
            }
        }
    }
}
