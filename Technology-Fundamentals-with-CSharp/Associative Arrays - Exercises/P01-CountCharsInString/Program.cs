namespace P01_CountCharsInString
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split(' ').ToArray();
            var occurences = new Dictionary<char, int>();

            for (int i = 0; i < words.Length; i++)
            {
                foreach (char letter in words[i])
                {
                    if (!occurences.ContainsKey(letter))
                    {
                        occurences[letter] = 0;
                    }

                    occurences[letter]++;
                }
            }

            foreach (var letter in occurences)
            {
                Console.WriteLine(letter.Key + " -> " + letter.Value);
            }
        }
    }
}
