namespace P01_Dictionary
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var dictionary = new SortedDictionary<string, List<string>>();
            var input = Console.ReadLine().Split(" | ");

            for (int i = 0; i < input.Length; i++)
            {
                var pair = input[i].Split(": ");
                string word = pair[0];
                string definition = pair[1];

                if (!dictionary.ContainsKey(word))
                {
                    dictionary.Add(word, new List<string>());
                }

                dictionary[word].Add(definition);
            }

            var choosenWords = Console.ReadLine().Split(" | ");

            foreach (var word in dictionary)
            {
                if (choosenWords.Contains(word.Key))
                {
                    Console.WriteLine(word.Key);
                    List<string> sortedDefinitions = word.Value.OrderByDescending(x => x.Length).ToList();

                    for (int i = 0; i < sortedDefinitions.Count; i++)
                    {
                        Console.WriteLine($" -{sortedDefinitions[i]}");
                    }
                }
            }

            string command = Console.ReadLine();

            if (command == "List")
            {
                foreach (var word in dictionary)
                {
                    Console.Write(word.Key + " ");
                }

                Console.WriteLine();
            }

            else if (command == "End")
            {
                return;
            }
        }
    }
}
