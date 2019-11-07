namespace P02_VowelsCount
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            Console.WriteLine(SumVowels(word));
        }

        public static int SumVowels(string word)
        {
            int sum = 0;

            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i])
                {
                    case 'a': 
                    case 'A': 
                    case 'e': 
                    case 'E': 
                    case 'i': 
                    case 'I': 
                    case 'o': 
                    case 'O': 
                    case 'u': 
                    case 'U':
                        sum++;
                        break;
                }
            }

            return sum;
        }
    }
}
